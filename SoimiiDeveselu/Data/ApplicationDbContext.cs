using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SoimiiDeveselu.Models;

namespace SoimiiDeveselu.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<ClubInfo> ClubInfos { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Standing> Standings { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollOption> PollOptions { get; set; }
    }
}