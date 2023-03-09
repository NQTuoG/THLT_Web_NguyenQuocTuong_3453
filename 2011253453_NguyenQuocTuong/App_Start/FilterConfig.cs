using System.Web;
using System.Web.Mvc;

namespace _2011253453_NguyenQuocTuong
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
