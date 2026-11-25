using Microsoft.AspNetCore.Mvc;
using SoimiiDeveselu.Models;

namespace SoimiiDeveselu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var clubInfo = new ClubInfo
            {
                StadiumName = "Stadionul Comunal Deveselu",
                Location = "Deveselu, jud. Olt",
                Capacity = 500,
                Surface = "Iarbă naturală",
                Dimensions = "100m x 64m",
                Description = "AS Șoimii Deveselu este echipa de fotbal a comunității locale, dedicată promovării sportului și spiritului de echipă în Liga a 5-a.",
                Goals = "OBIECTIVE\n- Clasarea pe podium în sezonul 2025/2026\n- Atragerea tinerilor din comună spre fotbal\nPALMARES\n- Participări constante în Liga a 5-a Olt"
            };

            return View(clubInfo);
        }
    }
}