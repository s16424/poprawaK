using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium3.DTOs;
using kolokwium3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace kolokwium3.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistController : ControllerBase
    {

        private readonly IDbService _context;
        public ArtistController(IDbService context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetArtist(int id)
        {
            if (!_context.ContainsArtist(id))
            {
                return BadRequest("Taki artysta nie istnieje");
            }
            return Ok(_context.GetArtist(id));
        }


        [HttpPut]
        public IActionResult ModifyEvent([FromBody] ModifyEventRequest request)
        {
            if (!_context.ContainsArtist(request.IdArtist))
                return BadRequest("Taki artysta nie istnieje");

            if (!_context.ContainsEvent(request.IdEvent))
                return BadRequest("Takie wydarzenie nie istnieje");
            
            _context.ModifyEvent(request);

            return Ok("Czas wydarzenia zmodyfikowano");
        }
    }
}


    