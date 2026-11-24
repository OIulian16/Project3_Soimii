using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class Transfer
    {
        [Key]
        public int TransferId { get; set; }

        public int PlayerId { get; set; }
        public virtual Player? Player { get; set; }

        [Required(ErrorMessage = "Clubul de provenienta este obligatoriu")]
        [StringLength(100)]
        public string FromClub { get; set; } = string.Empty;

        [Required(ErrorMessage = "Clubul de destinatie este obligatoriu")]
        [StringLength(100)]
        public string ToClub { get; set; } = string.Empty;

        [Required]
        public DateTime TransferDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(30)]
        public string Type { get; set; } = "Venire";

        [StringLength(50)]
        public string Fee { get; set; } = "Free";

        [Required]
        [StringLength(20)]
        public string Season { get; set; } = "26/27";
    }
}