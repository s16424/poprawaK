using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Models
{
    public class EventOrganiser
    {
        public Organiser Organiser { get; set; }
        public int IdOrganiser { get; set; }
        public Event Event { get; set; }
        public int IdEvent { get; set; }
    }
}
