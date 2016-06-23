using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        private static string GetHtmlForPrice(double price)
        {
            return price == 0.0 ? "<span>Free!!!</span>" : $"<span>{price}</span>";
        }
        private static string GetHtmlForDateTime(DateTime? Date)
        {
            return Date == null ? "<span>Free!!!</span>" : $"<span>{Date}</span>";
        }

        public static IHtmlString DisplayPriceStatic(double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }
        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayDateOrNull(this HtmlHelper helper, DateTime? Date)
        {
            return new HtmlString(GetHtmlForDateTime(Date));
        }
        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? Date)
        {
            return new HtmlString(GetHtmlForDateTime(Date));
        }
    }
}
