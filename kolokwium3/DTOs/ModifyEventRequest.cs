using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.DTOs
{
    public class ModifyEventRequest
    {
        [Required]
        public int IdArtist { get; set; }

        [Required]
        public int IdEvent { get; set; }

        [Required]
        public DateTime PerformanceDate { get; set; }
    }
}
