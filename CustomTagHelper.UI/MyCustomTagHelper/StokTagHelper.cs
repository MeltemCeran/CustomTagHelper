using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("stok-durum")]
    public class StokTagHelper : TagHelper
    {
        public int Stok { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "H2";

            string renk;
            string mesaj;

            if(Stok >20)
            {
                renk = "purple";
                mesaj = $"Stok durumu {Stok} adet - Yeterli adet var";
            }
            else if (Stok >10)
            {
                renk = "orange";
                mesaj = $"Stok durumu {Stok} adet - Pek yok :/";
            }
            else
            {
                renk = "red";
                mesaj = $"Stok durumu {Stok} adet - Bitti bitecek.";
            }

            output.Attributes.SetAttribute("style", $"color:{renk}");
            output.Content.SetContent(mesaj);
        }
    }
}
