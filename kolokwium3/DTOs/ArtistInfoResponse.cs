using kolokwium3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.DTOs
{
    public class ArtistInfoResponse
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public List<Event> EventsList { get; set; }

    }
}
