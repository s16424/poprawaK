using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Models
{
    public class Artist
    {
        [Key]
        public int IdArtist { get; set; }

        [MaxLength(30)]
        public string Nickname { get; set; }
    }
}
