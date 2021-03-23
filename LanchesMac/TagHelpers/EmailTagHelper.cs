using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Runtime.InteropServices;


namespace LanchesMac.TagHelpers
{
    public class EmailaTagHelper : TagHelper
    {
        public string Endreco { get; set; }
        public string Conteudo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Endreco);
            output.Content.SetContent(Conteudo);
        }
    }
}