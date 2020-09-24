using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCTuinCentrumCore.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Routing;

namespace MVCTuinCentrumCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("values", typeof(Constraints.ValuesConstraint)));
            services.AddControllersWithViews();
            services.AddDbContext<MVCTuinCentrumCoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("TuincentrumcoreConnection")));
            services.AddTransient<ILeveranciersRepository, SQLLeveranciersRepository>();
            services.AddTransient<ISoortenRepository, SQLSoortenRepository>();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supoortedCultures = new List<CultureInfo>
                {
                    new CultureInfo("nl-BE"),
                    new CultureInfo("nl"),
                    new CultureInfo("fr-BE"),
                    new CultureInfo("fr")
                };
                options.SupportedCultures = supoortedCultures;
                options.SupportedUICultures = supoortedCultures;
                options.DefaultRequestCulture = new RequestCulture("nl-Be");
            });
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddControllersWithViews((options) => {
                options.ModelBinderProviders.Insert(0, new CustomBinderProvider());
                //options.Filters.Add(new Filters.StatistiekActionFilter());
            })
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    app.UseStatusCodePagesWithRedirects("/Home/StatusCodeErrorPage?statusCode={0}");
            //}
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Alleplanten",
                    pattern: "Plantenlijst",
                    defaults: new { controller = "Plant", action = "Index" }
                    );
                endpoints.MapControllerRoute(
                    name: "PlantByNr",
                    pattern: "Plant/{id}",
                    defaults: new { controller = "Plant", action = "Details" },
                    constraints: new { id = new IntRouteConstraint() }
                    );
                endpoints.MapControllerRoute(
                    name: "PlantenVanEenSoort",
                    pattern: "soort/{soortnaam}/planten",
                    defaults: new { controller = "Plant", action = "FindPlantenBySoortNaam" },
                    constraints: new { soortnaam = new CompositeRouteConstraint(
                        new List<IRouteConstraint>
                        {
                            new AlphaRouteConstraint(),
                            new MinLengthRouteConstraint(3),
                            new MaxLengthRouteConstraint(10)
                        })
                    }
                    );
                endpoints.MapControllerRoute(
                    name: "PlantenVanEenLeverancier",
                    pattern: "leverancier/{levnr}/planten",
                    defaults: new { controller = "Plant", action = "FindPlantenByLeverancier" },
                    constraints: new { levnr = new MaxRouteConstraint(10) }
                    );
                endpoints.MapControllerRoute(
                    name: "PlantenMetGekendeKleur",
                    pattern: "plant/{kleur}",
                    defaults: new { controller = "Plant", action = "FindPlantenByKleur" },
                    constraints: new { kleur = new Constraints.KleurenConstaint() }
                    );
                endpoints.MapControllerRoute(
                    name: "FindPlantenByPrijsBetween",
                    pattern: "planten",
                    defaults: new { controller = "Plant", action = "FindPlantenBetweenPrijzen" },
                    constraints: new
                    {
                        QueryConstraint = new Constraints.QueryStringConstraint(
                        new string[] { "minprijs", "maxprijs" })
                    }
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
