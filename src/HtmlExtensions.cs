public static class HtmlHelperExtensions
{
    public static MvcHtmlString RenderScripts(this HtmlHelper helper)
    {
        var scripts = helper.ViewContext.HttpContext.Items["Scripts"] as IList<string>;
        if (scripts != null)
        {
            var builder = new StringBuilder();
            foreach (var script in scripts)
            {
                builder.AppendLine(script);
            }
            return new MvcHtmlString(builder.ToString());
        }
        return null;
    }
}
