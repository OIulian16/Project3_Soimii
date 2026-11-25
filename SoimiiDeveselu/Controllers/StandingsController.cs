using Microsoft.AspNetCore.Mvc;
using SoimiiDeveselu.Models;

namespace SoimiiDeveselu.Controllers
{
    public class StandingsController : Controller
    {
        public IActionResult Index()
        {
            var standings = new List<Standing>
            {
                new Standing { StandingId = 1, TeamName = "AS Șoimii Deveselu", MatchesPlayed = 6, Wins = 5, Draws = 1, Losses = 0, GoalsFor = 18, GoalsAgainst = 5, Points = 16 },
                new Standing { StandingId = 2, TeamName = "Avântul Traian", MatchesPlayed = 6, Wins = 4, Draws = 1, Losses = 1, GoalsFor = 14, GoalsAgainst = 7, Points = 13 },
                new Standing { StandingId = 3, TeamName = "Unirea Stoenești", MatchesPlayed = 6, Wins = 3, Draws = 1, Losses = 2, GoalsFor = 11, GoalsAgainst = 9, Points = 10 },
                new Standing { StandingId = 4, TeamName = "FC Viitorul Vlădila", MatchesPlayed = 6, Wins = 1, Draws = 1, Losses = 4, GoalsFor = 6, GoalsAgainst = 15, Points = 4 },
                new Standing { StandingId = 5, TeamName = "Recolta Redea", MatchesPlayed = 6, Wins = 0, Draws = 2, Losses = 4, GoalsFor = 4, GoalsAgainst = 17, Points = 2 }
            };

            return View(standings.OrderByDescending(s => s.Points).ToList());
        }
    }
}