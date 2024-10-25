using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("alkin")]
    public class AlkinTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.SetAttribute("style","color:pink;");
            output.Content.SetContent("Çikolata yemek");
        }
    }
}
