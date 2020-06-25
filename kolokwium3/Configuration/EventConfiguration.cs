using kolokwium3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>

    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            var EventData = new List<Event>();

            EventData.Add(new Event
            {
                IdEvent = 1,
                Name = "Koncert"
            });

            EventData.Add(new Event
            {
                IdEvent = 2,
                Name = "SZtuka teatralna"
            });

            builder.HasData(EventData);
        }


    }
}
