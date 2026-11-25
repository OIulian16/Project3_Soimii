using Microsoft.AspNetCore.Mvc;
using SoimiiDeveselu.Models;

namespace SoimiiDeveselu.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index(string? searchString, bool showInactive = false)
        {
            ViewData["ShowInactive"] = showInactive;
            ViewData["CurrentFilter"] = searchString;

            var players = new List<Player>
            {
                new Player { PlayerId = 1, Name = "Iulian Marian", Age = 22, Position = "Mijlocaș", Number = 17, IsActive = true },
                new Player { PlayerId = 2, Name = "Mihai Ionescu", Age = 24, Position = "Fundaș", Number = 4, IsActive = true },
                new Player { PlayerId = 3, Name = "Vlad Marin", Age = 18, Position = "Fundaș", Number = 5, IsActive = true },
                new Player { PlayerId = 4, Name = "Ștefan Radu", Age = 22, Position = "Portar", Number = 8, IsActive = true },
                new Player { PlayerId = 5, Name = "Alexandru Dinu", Age = 25, Position = "Atacant", Number = 9, IsActive = true }
            };

            if (!string.IsNullOrEmpty(searchString))
            {
                players = players
                    .Where(p => p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View(players);
        }
    }
}
