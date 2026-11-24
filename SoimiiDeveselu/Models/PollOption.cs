using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class PollOption
    {
        [Key]
        public int PollOptionId { get; set; }

        [Required(ErrorMessage = "Textul optiunii este obligatoriu")]
        [StringLength(150)]
        public string OptionText { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int VotesCount { get; set; } = 0;

        public int PollId { get; set; }
        public virtual Poll? Poll { get; set; }
    }
}