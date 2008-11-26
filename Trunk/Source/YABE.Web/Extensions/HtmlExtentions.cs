namespace YABE.Web.Extensions
{
    using System;
    using System.Text;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class HtmlExtentions
    {
        public static string CustomValidationSummary(this HtmlHelper helper)
        {
            return CustomValidationSummary(helper, "Oops! - There was a problem");
        }

        public static string CustomValidationSummary(this HtmlHelper helper, string title) 
        {
            if (helper.ViewDataContainer.ViewData.ModelState.IsValid) { return null; }

            var html = new StringBuilder();

            html.Append("<div class='validation-summary'>");
            html.Append(String.Format("<div class='validation-summary-title'>{0}</div>", title));
            html.Append(helper.ValidationSummary());
            html.Append("</div");

            return html.ToString();
        }
    }
}