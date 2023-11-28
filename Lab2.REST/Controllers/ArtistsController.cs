using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MusicWebAPI.DTOs;
using MusicWebAPI.Models;
using MusicWebAPI.Repositories;

namespace MusicWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyPolicy")]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistRepository _repository;
        private readonly IMapper _mapper;

        public ArtistsController(IArtistRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ArtistOutDTO>>> Get()
        {
            var result = await _repository.GetAllAsync();
            return Ok(_mapper.Map<List<ArtistOutDTO>>(result));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArtistOutDTO>> GetById(int id)
        {
            try
            {
                var result = await _repository.GetByIdAsync(id);
                return Ok(_mapper.Map<ArtistOutDTO>(result));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<ArtistOutDTO>> Post(ArtistInDTO artist)
        {
            try
            {
                var result = await _repository.AddAsync(_mapper.Map<Artist>(artist));
                return Ok(_mapper.Map<ArtistOutDTO>(result));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);

                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ArtistOutDTO?>> Put(int id, ArtistInDTO editedArtist)
        {
            try
            {
                var result = await _repository.UpdateAsync(id, editedArtist);
                return Ok(_mapper.Map<ArtistOutDTO>(result));
            }
            catch (BadHttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}