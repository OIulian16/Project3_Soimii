using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class ClubInfo
    {
        [Key]
        public int ClubInfoId { get; set; }

        [Required(ErrorMessage = "Numele stadionului este obligatoriu")]
        [StringLength(150)]
        public string? StadiumName { get; set; }

        [StringLength(150)]
        public string? Location { get; set; }

        [Range(0, 100000, ErrorMessage = "Capacitatea trebuie sa fie mai mare decat 0")]
        public int Capacity { get; set; }

        [StringLength(50)]
        public string? Surface { get; set; }

        [StringLength(50)]
        public string? Dimensions { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

        [StringLength(1000)]
        public string? Goals { get; set; }
    }
}