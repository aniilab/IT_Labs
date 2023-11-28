using System.ComponentModel.DataAnnotations;

namespace MusicWebAPI.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? PseudoName { get; set; }
        [Required]
        public string Country { get; set; }

        public ICollection<Song>? Songs { get; set; }

    }
}
