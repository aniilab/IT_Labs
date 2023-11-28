using System.ComponentModel.DataAnnotations;

namespace MusicWebAPI.DTOs
{
    public class SongOutDTO
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Duration { get; set; }
        public string? Lyrics { get; set; }
        public string AuthorName { get; set; }

    }
}