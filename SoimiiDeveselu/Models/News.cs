using System.ComponentModel.DataAnnotations;

namespace SoimiiDeveselu.Models
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }

        [Required(ErrorMessage = "Titlul stirii este obligatoriu")]
        [StringLength(200, MinimumLength = 5)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Continutul stirii este obligatoriu")]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Url(ErrorMessage = "Link-ul nu este valid")]
        public string? ImageUrl { get; set; }

        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}