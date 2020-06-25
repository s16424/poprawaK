using kolokwium3.DTOs;
using kolokwium3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Services
{
    public class EfDbService : IDbService
    {
        private readonly MyDbContext _context;

        public EfDbService(MyDbContext context)
        {
            _context = context;
        }

        public bool ContainsArtist(int id)
        {
            if (!_context.Artists.Any(x => x.IdArtist == id))
            {
                return false;
            }
            return true;

        }
        public bool ContainsEvent(int id)
        {
            if(!_context.Events.Any(x => x.IdEvent == id))
            {
                return false;
            }
            return true;
        }


        public ArtistInfoResponse GetArtist(int id)
        {
            ArtistInfoResponse result = new ArtistInfoResponse();
            result.ID = id;
            var name = _context.Artists.Where(x => x.IdArtist == id).Select(e => e.Nickname).FirstOrDefault();
           
            result.Nickname = name;

            //var events = _context.ArtistEvents.Where(x => x.IdArtist == id);
            //foreach ( var i in events)
            //{
            //    var y = _context.Events.Where(x => x.IdEvent == i.IdEvent).ToList();
            //    result.EventsList = y;
            //} 
            return result;
        }

        public void ModifyEvent(ModifyEventRequest req)
        {
            var ev = _context.Events.FirstOrDefault(e => e.IdEvent == req.IdEvent);
            DateTime start = ev.StartDate;
            DateTime end = ev.EndDate;
           
            if(req.PerformanceDate.CompareTo(start)>=0 && req.PerformanceDate.CompareTo(end) <= 0)
            {
                ev.StartDate = req.PerformanceDate;
                _context.SaveChanges();
            }
            
        }

    }
}
