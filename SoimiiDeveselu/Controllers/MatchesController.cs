using Microsoft.AspNetCore.Mvc;
using SoimiiDeveselu.Models;

namespace SoimiiDeveselu.Controllers
{
    public class MatchesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PastMatches = new List<Match>
            {
                new Match
                {
                    MatchId = 1,
                    HomeTeam = "AS Șoimii Deveselu",
                    AwayTeam = "FC Viitorul Vlădila",
                    MatchDate = new DateTime(2026, 10, 18, 11, 0, 0),
                    HomeScore = 3,
                    AwayScore = 1,
                    IsFinished = true,
                    Round = 5,
                    Location = "Stadionul Comunal Deveselu"
                },
                new Match
                {
                    MatchId = 2,
                    HomeTeam = "Unirea Stoenești",
                    AwayTeam = "AS Șoimii Deveselu",
                    MatchDate = new DateTime(2026, 10, 25, 11, 0, 0),
                    HomeScore = 1,
                    AwayScore = 2,
                    IsFinished = true,
                    Round = 6,
                    Location = "Teren Stoenești"
                }
            };

            ViewBag.UpcomingMatches = new List<Match>
            {
                new Match
                {
                    MatchId = 3,
                    HomeTeam = "AS Șoimii Deveselu",
                    AwayTeam = "Avântul Traian",
                    MatchDate = new DateTime(2026, 11, 29, 11, 0, 0),
                    IsFinished = false,
                    Round = 7,
                    Location = "Stadionul Comunal Deveselu"
                }
            };

            return View();
        }
    }
}