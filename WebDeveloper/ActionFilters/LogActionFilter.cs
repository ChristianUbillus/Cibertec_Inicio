using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        void Linea(string Opcion, RouteData RouteData )
        {
            Debug.WriteLine($"{Opcion} controller:{ RouteData.Values["controller"]} action:{ RouteData.Values["action"]}", "Action Filter Log");
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Linea("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Linea("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Linea("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Linea("OnResultExecuting", filterContext.RouteData);
        }
    }
}
