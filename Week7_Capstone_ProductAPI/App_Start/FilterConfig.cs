using System.Web;
using System.Web.Mvc;

namespace Week7_Capstone_ProductAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
