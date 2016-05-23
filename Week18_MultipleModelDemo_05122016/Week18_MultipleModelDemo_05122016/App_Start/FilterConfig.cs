using System.Web;
using System.Web.Mvc;

namespace Week18_MultipleModelDemo_05122016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
