using System.Web;
using System.Web.Mvc;

namespace PhamQuangLong_1911067466_LAB456
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
