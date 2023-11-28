using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicWebAPI.DTOs;
using MusicWebAPI.Models;
using MusicWebAPI.Repositories;

namespace MusicWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        private readonly ISongRepository _repository;
        private readonly IMapper _mapper;

        public SongsController(ISongRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<SongOutDTO>>> Get()
        {
            var result = await _repository.GetAllAsync();
            var songOutDtos = result.Select(s => _mapper.Map<SongOutDTO>(s)).ToList();
            return Ok(songOutDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SongOutDTO?>> GetById(int id)
        {
            try
            {
                var result = await _repository.GetByIdAsync(id);
                return Ok(_mapper.Map<SongOutDTO>(result));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<SongOutDTO?>> Post(SongInDTO song)
        {
            try
            {
                var model = _mapper.Map<Song>(song);
                var result = await _repository.AddAsync(model);
                return Ok(_mapper.Map<SongOutDTO>(result));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
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
        public async Task<ActionResult<SongOutDTO?>> Put(int id, SongInDTO editedSong)
        {
            try
            {
                var result = await _repository.UpdateAsync(id, _mapper.Map<Song>(editedSong));
                return Ok(_mapper.Map<SongOutDTO>(result));
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