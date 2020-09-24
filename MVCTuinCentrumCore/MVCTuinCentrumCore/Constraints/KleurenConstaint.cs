using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Constraints
{
    public class KleurenConstaint : IRouteConstraint
    {
        private static string[] GekendeKleuren = new[]
        {
            "oranje",
            "rood",
            "geel",
            "bruin",
            "wit",
            "blauw",
            "groen",
            "ongekend",
            "paars",
            "gemengd",
            "lila",
            "violet",
            "roze"
        };
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return GekendeKleuren.Contains(values[routeKey]?.ToString().ToLowerInvariant());
        }
    }
}
