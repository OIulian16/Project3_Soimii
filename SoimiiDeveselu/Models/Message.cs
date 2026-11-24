using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mesajul nu poate fi gol")]
        [StringLength(1000, ErrorMessage = "Mesajul poate avea maxim 1000 de caractere")]
        public string Content { get; set; } = string.Empty;

        public DateTime DateSent { get; set; } = DateTime.Now;

        public int NewsId { get; set; }
        public virtual News? News { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }
    }
}