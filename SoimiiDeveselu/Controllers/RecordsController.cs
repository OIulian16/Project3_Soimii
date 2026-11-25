using Microsoft.AspNetCore.Mvc;
using SoimiiDeveselu.Models;

namespace SoimiiDeveselu.Controllers
{
    public class RecordsController : Controller
    {
        public IActionResult Index(string season = "26/27")
        {
            ViewData["CurrentSeason"] = season;

            ViewBag.TeamRecords = new List<Record>
            {
                new Record { RecordId = 1, Type = "Goluri marcate", Value = 18, Season = season },
                new Record { RecordId = 2, Type = "Goluri primite", Value = 5, Season = season },
                new Record { RecordId = 3, Type = "Medie spectatori", Value = 180, Season = season }
            };

            ViewBag.PlayerRecords = new List<Record>
            {
                new Record { RecordId = 4, Type = "Golgheter", Value = 7, Season = season, Player = new Player { Name = "Alexandru Dinu" } },
                new Record { RecordId = 5, Type = "Cele mai multe pase de gol (Assist)", Value = 5, Season = season, Player = new Player { Name = "Ștefan Radu" } },
                new Record { RecordId = 6, Type = "Omul meciului", Value = 3, Season = season, Player = new Player { Name = "Andrei Popescu" } }
            };

            return View();
        }
    }
}