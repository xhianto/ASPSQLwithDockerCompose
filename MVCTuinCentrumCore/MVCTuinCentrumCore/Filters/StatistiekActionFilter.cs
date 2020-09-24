using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Filters
{
    public class StatistiekActionFilter : ActionFilterAttribute
    {
        static Dictionary<string, int> statistiek = new Dictionary<string, int>();
        public static Dictionary<string, int> Statistiek
        {
            get
            {
                return statistiek;
            }
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string url = filterContext.HttpContext.Request.Path.ToString();
            lock (statistiek)
            {
                if (statistiek.ContainsKey(url))
                    if (statistiek[url] > 3)
                        filterContext.Result = new ViewResult()
                        {
                            ViewName = "~/Views/Statistiek/Error.cshtml"
                        };
                    else
                        statistiek[url]++;
                else
                    statistiek[url] = 1;
            }
        }
    }
}
