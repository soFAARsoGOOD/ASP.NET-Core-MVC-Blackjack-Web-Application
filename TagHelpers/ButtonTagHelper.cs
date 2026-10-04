using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlackJack.TagHelpers
{
    [HtmlTargetElement("action-button")]
    public class ButtonTagHelper : TagHelper
    {
        [HtmlAttributeName("action")]
        public string Action { get; set; } = "";

        [HtmlAttributeName("controller")]
        public string Controller { get; set; } = "Home"; // Default controller

        [HtmlAttributeName("disabled")]
        public bool Disabled { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "form";
            output.Attributes.SetAttribute("method", "post");
            output.Attributes.SetAttribute("action", $"/{Controller}/{Action}"); // Explicitly set action route

            var button = new TagBuilder("button");
            button.Attributes.Add("type", "submit");
            button.AddCssClass("btn btn-primary");

            if (Disabled)
            {
                button.Attributes.Add("disabled", "disabled");
            }

            button.InnerHtml.Append(Action); // Button text

            output.Content.SetHtmlContent(button);
        }
    }
}
