using Microsoft.AspNetCore.Mvc;
using BlackJack.Models;

namespace BlackJack.ViewComponents
{
    public class HandViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Hand hand)
        {
            return View(hand);
        }
    }
}

