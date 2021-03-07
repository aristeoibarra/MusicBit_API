using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicBit.Core.DTOs;
using MusicBit.Core.Entities;
using MusicBit.Core.Interfaces;
using MusicBit.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistRepository _artistRepository; 
        private readonly IMapper _mapper;

        public ArtistController(IArtistRepository artistRepository , IMapper mapper)
        {
            _artistRepository = artistRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArtists()
        {
            var artists = await _artistRepository.GetArtists();
            var artistsDto = _mapper.Map<IEnumerable<ArtistDto>>(artists);

            return Ok(artistsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtist(int id)
        {
            var artist = await _artistRepository.GetArtist(id);
            var artistDto = _mapper.Map<ArtistDto>(artist);

            return Ok(artistDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostArtist(ArtistDto artistDto)
        {
            var artist = _mapper.Map<Artist>(artistDto);

            await _artistRepository.InsertArtist(artist);
            return Ok(artist);
        }
    }
}
