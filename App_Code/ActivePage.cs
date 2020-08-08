using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HtmlHelpersApp.App_Code
{
    public static class ActivePage
    {
        public static string isActivePage(this IHtmlHelper html, string controller)
        {
            string classValue = "";

            string currentController = html.ViewContext.RouteData.Values["controller"].ToString();

            if(controller == currentController)
            {
                classValue = "active";
            }

            return classValue;
        }
    }
}
