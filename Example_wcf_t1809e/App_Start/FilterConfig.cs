using System.Web;
using System.Web.Mvc;

namespace Example_wcf_t1809e
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
