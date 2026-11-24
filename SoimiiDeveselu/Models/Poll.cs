using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class Poll
    {
        [Key]
        public int PollId { get; set; }

        [Required(ErrorMessage = "Intrebarea este obligatorie")]
        [StringLength(250)]
        public string Question { get; set; } = string.Empty;

        public virtual ICollection<PollOption> PollOptions { get; set; } = new List<PollOption>();
    }
}