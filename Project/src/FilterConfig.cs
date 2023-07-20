using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce
{
    public class FilterConfig  
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filter)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
