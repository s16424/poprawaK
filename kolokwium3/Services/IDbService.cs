using kolokwium3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Services
{
    public interface IDbService
    {
        public ArtistInfoResponse GetArtist(int id);
        public bool ContainsArtist(int id);
        public bool ContainsEvent(int id);

        public void ModifyEvent(ModifyEventRequest req);
    }
}
