using MusicWebAPI.Models;

namespace MusicWebAPI.Repositories
{
    public interface ISongRepository
    {
        Task<IEnumerable<Song>> GetAllAsync();

        Task<Song> GetByIdAsync(int id);

        Task<Song> AddAsync(Song song);

        Task<Song> UpdateAsync(int id, Song editedSong);

        Task DeleteAsync(int id);
    }
}

