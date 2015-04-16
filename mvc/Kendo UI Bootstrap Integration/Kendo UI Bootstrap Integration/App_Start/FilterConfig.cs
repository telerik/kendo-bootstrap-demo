using System.Web;
using System.Web.Mvc;

namespace Kendo_UI_Bootstrap_Integration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
