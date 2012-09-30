using System.Windows.Forms;
using PageMapper.Models;

namespace PageMapper.Extensions
{
    public static class HtmlElementExtensions
    {
        public static WebElement AsWebElement(this HtmlElement element)
        {
            return new WebElement
            {
                Id = element.Id,
                Name = element.Name,
                TagName = element.TagName,
                ClassName = element.GetAttribute("class"),
                Html = element.OuterHtml
            };
        }
    }
}