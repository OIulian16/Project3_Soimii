using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class Record
    {
        [Key]
        public int RecordId { get; set; }

        [Required(ErrorMessage = "Tipul recordului este obligatoriu")]
        [StringLength(150)]
        public string Type { get; set; } = string.Empty;

        public int? PlayerId { get; set; }
        public virtual Player? Player { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Valoarea nu poate fi negativa")]
        public int Value { get; set; }

        [Required(ErrorMessage = "Sezonul este obligatoriu")]
        [StringLength(20)]
        public string Season { get; set; } = "26/27";
    }
}