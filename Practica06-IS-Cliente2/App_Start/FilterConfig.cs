using System.Web;
using System.Web.Mvc;

namespace Practica06_IS_Cliente2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
