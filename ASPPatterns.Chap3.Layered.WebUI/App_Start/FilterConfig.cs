using System.Web;
using System.Web.Mvc;

namespace ASPPatterns.Chap3.Layered.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
