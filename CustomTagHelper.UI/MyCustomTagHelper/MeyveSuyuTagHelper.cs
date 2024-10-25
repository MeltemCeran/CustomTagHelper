using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("meyvesuyu")]
    public class MeyveSuyuTagHelper : TagHelper
    {
        public string Tur { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "H2";

            string renk = "";
            string mesaj = "";

            if (Tur == "Karisik")
            {
                renk = "purple";
                mesaj = $"{Tur} meyve suyu çeek";
            }
            else if (Tur == "Seftali")
            {
                renk = "orange";
                mesaj = $"{Tur} batuyu çağırın";
            }
            else if (Tur == "Elma")
            {
                renk = "yellow";
                mesaj = $"{Tur} efnaaan";
            }
            output.Attributes.SetAttribute("style", $"color:{renk}");
            output.Content.SetContent(mesaj);
        }
    }
}
