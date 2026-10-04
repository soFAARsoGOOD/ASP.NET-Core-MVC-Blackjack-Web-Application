using Microsoft.AspNetCore.Mvc;
using BlackJack.Models;

namespace BlackJack.ViewComponents
{
    public class PlayerWinningsViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _accessor;

        public PlayerWinningsViewComponent(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public IViewComponentResult Invoke()
        {
            var session = _accessor.HttpContext?.Session;
            var player = session?.GetObject<Player>("player") ?? new Player();
            return View(player.TotalWinnings);
        }
    }
}
