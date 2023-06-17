using System.Text;

namespace HTMLTemplateBuilder
{
    class HtmlTemplateBuilder
    {
        private StringBuilder templateBuilder;

        public HtmlTemplateBuilder()
        {
            templateBuilder = new StringBuilder();
        }

        public HtmlTemplateBuilder AddHeader(string title)
        {
            templateBuilder.Append($"<!DOCTYPE html><html><head><title>{title}</title></head><body>");
            return this;
        }

        public HtmlTemplateBuilder AddParagraph(string text)
        {
            templateBuilder.Append($"<p>{text}</p>");
            return this;
        }

        public HtmlTemplateBuilder AddList(string[] items)
        {
            templateBuilder.Append("<ul>");
            foreach (string item in items)
            {
                templateBuilder.Append($"<li>{item}</li>");
            }
            templateBuilder.Append("</ul>");
            return this;
        }

        public string Build()
        {
            templateBuilder.Append("</body></html>");
            string template = templateBuilder.ToString();
            templateBuilder.Clear();
            return template;
        }
    }
}
