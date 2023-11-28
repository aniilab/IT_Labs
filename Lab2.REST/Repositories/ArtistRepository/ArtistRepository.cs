using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MusicWebAPI.DTOs;
using MusicWebAPI.Models;

namespace MusicWebAPI.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MusicDbContext _context;
        private readonly IMapper _mapper;
        public ArtistRepository(MusicDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Artist>> GetAllAsync()
        {
            return await _context.Artists.Include(a => a.Songs)
                                         .ToListAsync();
        }
        public async Task<Artist> GetByIdAsync(int id)
        {
            var existing = await _context.Artists.FindAsync(id);
            if (existing == null)
            {
                throw new KeyNotFoundException("Artist with this Id not found");
            }
            return existing;
        }

        public async Task<Artist> AddAsync(Artist artist)
        {
            var existing = _context.Artists.FirstOrDefault(a => a.Id == artist.Id);
            if (existing != null)
            {
                throw new ArgumentException("Artist with this Id already exists!");
            }

            await _context.Artists.AddAsync(artist);
            await _context.SaveChangesAsync();
            return artist;
        }

        public async Task DeleteAsync(int id)
        {
            var art = _context.Artists.FirstOrDefault(a => a.Id == id);
            if (art == null)
            {
                throw new KeyNotFoundException("Artist with this Id not found");
            }
            _context.Artists.Remove(art);
            await _context.SaveChangesAsync();
        }

        public async Task<Artist> UpdateAsync(int id, ArtistInDTO editedArtist)
        {
            var existing = _context.Artists.FirstOrDefault(a => a.Id == id);
            if (existing == null)
            {
                throw new KeyNotFoundException("Artist with this Id not found");
            }
            else
            {
                existing.FirstName = editedArtist.FirstName;
                existing.LastName = editedArtist.LastName;
                existing.PseudoName = editedArtist.PseudoName;
                existing.Country = editedArtist.Country;
                _context.Artists.Update(existing);
                await _context.SaveChangesAsync();
            }
            return existing;
        }

    }
}
