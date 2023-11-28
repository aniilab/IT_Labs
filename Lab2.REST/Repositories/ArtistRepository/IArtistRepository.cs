using MusicWebAPI.DTOs;
using MusicWebAPI.Models;

namespace MusicWebAPI.Repositories
{
    public interface IArtistRepository
    {
        Task<IEnumerable<Artist>> GetAllAsync();

        Task<Artist> GetByIdAsync(int id);

        Task<Artist> AddAsync(Artist artist);

        Task<Artist> UpdateAsync(int id, ArtistInDTO editedArtist);

        Task DeleteAsync(int id);
    }
}
