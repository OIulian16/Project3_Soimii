using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class Standing
    {
        [Key]
        public int StandingId { get; set; }

        [Required(ErrorMessage = "Numele echipei este obligatoriu")]
        [StringLength(100)]
        public string TeamName { get; set; } = string.Empty;

        [Range(0, 100)]
        public int MatchesPlayed { get; set; }

        [Range(0, 100)]
        public int Wins { get; set; }

        [Range(0, 100)]
        public int Draws { get; set; }

        [Range(0, 100)]
        public int Losses { get; set; }

        [Range(0, 300)]
        public int GoalsFor { get; set; }

        [Range(0, 300)]
        public int GoalsAgainst { get; set; }

        [Range(0, 300)]
        public int Points { get; set; }
    }
}