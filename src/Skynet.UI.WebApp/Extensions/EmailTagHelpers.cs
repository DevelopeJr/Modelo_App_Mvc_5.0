
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Skynet.UI.WebApp.Extensions
{
    public class EmailTagHelpers : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + "gmail.com";
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);

        }
    }
}