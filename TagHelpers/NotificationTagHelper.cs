using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlackJack.TagHelpers
{
    public class NotificationTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly ITempDataDictionaryFactory _tempDataFactory;

        public NotificationTagHelper(IHttpContextAccessor accessor, ITempDataDictionaryFactory tempDataFactory)
        {
            _accessor = accessor;
            _tempDataFactory = tempDataFactory;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tempData = _tempDataFactory.GetTempData(_accessor.HttpContext);

            if (tempData?.ContainsKey("message") == true)
            {
                string message = tempData["message"]?.ToString() ?? "";
                string background = tempData["background"]?.ToString() ?? "info"; // Default color

                output.TagName = "div";
                output.Attributes.SetAttribute("class", $"alert alert-{background}");
                output.Content.SetContent(message);
            }
            else
            {
                output.SuppressOutput(); // Ensures no output if no message exists
            }
        }
    }
}
