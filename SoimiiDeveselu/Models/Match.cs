using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }

        [Required(ErrorMessage = "Echipa gazda este obligatorie")]
        [StringLength(100)]
        public string HomeTeam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Echipa oaspete este obligatorie")]
        [StringLength(100)]
        public string AwayTeam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Data meciului este obligatorie")]
        public DateTime MatchDate { get; set; }

        [Range(0, 50)]
        public int HomeScore { get; set; } = 0;

        [Range(0, 50)]
        public int AwayScore { get; set; } = 0;

        public bool IsFinished { get; set; } = false;

        [Range(1, 50, ErrorMessage = "Etapa este între 1 si 50")]
        public int Round { get; set; }

        [StringLength(150)]
        public string? Location { get; set; }
    }
}