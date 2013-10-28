using System.Web;
using System.Web.Mvc;

namespace HR_Lesson3_Fall_2011.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}