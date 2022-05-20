using System.Web;
using System.Web.Mvc;

namespace _16012775_CLDV_POE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
