using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace FD.ToFollowUp.WebUI.Constraints
{
    public class Programlama:IRouteConstraint
    {
        public List<string> programlamalaDilleri=new List<string>{"csharp","java","php"};
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            return programlamalaDilleri.Contains(values[routeKey].ToString().ToLower());
        }
    }
}
