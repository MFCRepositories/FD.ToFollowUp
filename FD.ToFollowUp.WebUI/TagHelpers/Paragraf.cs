using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FD.ToFollowUp.WebUI.TagHelpers
{
    [HtmlTargetElement("fatih")]
    public class Paragraf:TagHelper
    {
        public string GelenData { get; set; } = "Bundandır böyle dibe vuruşumuz";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //string data ;
            //tagbuilder
            //string builder 


            //<p><b>Fatih Ceylan></p>
            var tagBuilder = new TagBuilder("a href");
            tagBuilder.InnerHtml.AppendHtml("<b>Fatih Ceylan</b>");
            output.Content.SetHtmlContent(tagBuilder);

            //var stringBuilder = new StringBuilder();
            //stringBuilder.AppendFormat("<p><b>{0}</b></p>", GelenData );
            //output.Content.SetHtmlContent(stringBuilder.ToString());


            //string data = string.Empty;
            //data = "<p><b>" + GelenData + "</b></p>";
            //output.Content.SetHtmlContent(data);

        }
    }
}
