using Microsoft.AspNetCore.Razor.TagHelpers;
using BlackJack.Models;

namespace BlackJack.TagHelpers
{
    [HtmlTargetElement("hand-heading")]
    public class HandHeadingTagHelper : TagHelper
    {
        [HtmlAttributeName("player")]
        public Player Player { get; set; }

        [HtmlAttributeName("dealer")]
        public Dealer Dealer { get; set; }

        [HtmlAttributeName("type")]
        public string Type { get; set; } // "Player" or "Dealer"

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string heading = Type;

            if (Type == "Dealer" && Dealer?.MustShowCards == true)
            {
                heading += $": {Dealer.Hand.Total}";
            }
            else if (Type == "Player" && Player?.Hand.HasCards == true)
            {
                heading += $": {Player.Hand.Total}";
            }

            output.TagName = "h5";
            output.Content.SetContent(heading);
        }
    }
}
