using System.Web;
using System.Web.Mvc;

namespace AngularJS_For_ASP.NET_Developers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}