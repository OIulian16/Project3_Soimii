using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace SoimiiDeveselu.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Numele jucatorului este obligatoriu")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Range(14, 55, ErrorMessage = "Varsta trebuie sa fie între 14 si 55 de ani")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Postul este obligatoriu")]
        [StringLength(50)]
        public string Position { get; set; } = string.Empty;

        [Range(1, 99, ErrorMessage = "Numarul de pe tricou trebuie sa fie de la 1 la 99")]
        public int Number { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Transfer>? Transfers { get; set; }
        public virtual ICollection<Record>? Records { get; set; }
    }
}