namespace MusicWebAPI.DTOs
{
    public class ArtistOutDTO
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PseudoName { get; set; }
        public string Country { get; set; }
        public ICollection<SongOutDTO> Songs { get; set; }
    }
}
