using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Models
{
    public class Organiser
    {
        [Key]
        public int IdOrganiser { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }
    }
}
