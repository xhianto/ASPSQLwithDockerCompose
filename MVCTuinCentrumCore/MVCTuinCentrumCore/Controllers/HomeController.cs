using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTuinCentrumCore.Models;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace MVCTuinCentrumCore.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            this.localizer = localizer;
        }
        [Route("/")]
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            ViewBag.Welkomsttekst = localizer["Welkom"];
            return View();
        }

        [Route("Prive")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        [Route("[action]")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("[action]")]
        public IActionResult TaalInstellen(string culture, string returnUrl)
        {
            RequestCulture requestCulture = new RequestCulture(culture);
            string cultureCookie = CookieRequestCultureProvider.MakeCookieValue(requestCulture);
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, cultureCookie, option);
            return LocalRedirect(returnUrl);
        }
        [Route("[action]")]
        public IActionResult StatusCodeErrorPage(int statusCode)
        {
            Response.StatusCode = statusCode;
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "De gevraagde URL werd niet gevonden.";
                    break;
            }
            return View();
        }
        [HttpGet("Verb")]
        public IActionResult GetVerb()
        {
            //info ophalen en doorgeven aan view
            return View();
        }
        [HttpPost("Verb")]
        public IActionResult PostVerb()
        {
            //form verwerken en redirecten
            return Redirect("/");
        }
    }
}
