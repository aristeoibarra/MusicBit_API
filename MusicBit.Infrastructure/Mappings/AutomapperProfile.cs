using MusicBit.Core.DTOs;
using MusicBit.Core.Entities;

namespace MusicBit.Infrastructure.Mappings
{
    public class AutomapperProfile : AutoMapper.Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Artist, ArtistDto>();
            CreateMap<ArtistDto, Artist>();
        }
    }
}
