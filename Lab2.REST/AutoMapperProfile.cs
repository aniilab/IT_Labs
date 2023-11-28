using AutoMapper;
using MusicWebAPI.DTOs;
using MusicWebAPI.Models;

namespace MusicWebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SongInDTO, Song>();
            CreateMap<Song, SongOutDTO>().ForMember(dest => dest.AuthorName, opt => opt
                                         .MapFrom(src => $"{src.Author.FirstName} {src.Author.LastName} ({src.Author.PseudoName})"));
            CreateMap<ArtistInDTO, Artist>();
            CreateMap<Artist, ArtistOutDTO>();
        }
    }
}
