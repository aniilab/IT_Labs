using Microsoft.EntityFrameworkCore;
using MusicWebAPI.Models;

namespace MusicWebAPI.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly MusicDbContext _context;
        public SongRepository(MusicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Song>> GetAllAsync()
        {
            return await _context.Songs.Include(s => s.Author)
                                       .ToListAsync();
        }
        public async Task<Song> GetByIdAsync(int id)
        {
            var existing = (await GetAllAsync()).FirstOrDefault(s => s.Id == id);
            if (existing == null)
            {
                throw new KeyNotFoundException("Song with this Id not found");
            }
            return existing;
        }

        public async Task<Song> AddAsync(Song song)
        {
            var existing = _context.Songs.FirstOrDefault(s => s.Id == song.Id);
            if (existing != null)
            {
                throw new ArgumentException("Song with this Id already exists!");
            }

            var existingArtist = _context.Artists.FirstOrDefault(a => a.Id == song.AuthorId);
            if (existingArtist == null)
            {
                throw new ArgumentException("Artist with this Id not found");
            }

            await _context.Songs.AddAsync(song);
            await _context.SaveChangesAsync();
            return song;
        }

        public async Task DeleteAsync(int id)
        {
            var song = _context.Songs.FirstOrDefault(a => a.Id == id);
            if (song == null)
            {
                throw new KeyNotFoundException("Song with this Id not found");
            }
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
        }

        public async Task<Song> UpdateAsync(int id, Song editedSong)
        {
            if (id != editedSong.Id)
                throw new BadHttpRequestException("Song Id mismatch");

            var existing = _context.Songs.FirstOrDefault(a => a.Id == id);
            if (existing == null)
            {
                throw new KeyNotFoundException("Song with this Id not found");
            }

            var existingArtist = _context.Artists.FirstOrDefault(a => a.Id == editedSong.AuthorId);
            if (existingArtist == null)
            {
                throw new ArgumentException("Artist with this Id not found");
            }

            _context.Songs.Update(editedSong);
            await _context.SaveChangesAsync();

            return editedSong;
        }
    }
}
