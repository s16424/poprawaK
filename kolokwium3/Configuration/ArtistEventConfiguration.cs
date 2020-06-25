using kolokwium3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Configuration
{
    public class ArtistEventConfiguration : IEntityTypeConfiguration<ArtistEvent>

    {
        public void Configure(EntityTypeBuilder<ArtistEvent> builder)
        {
            var ArtistEventData = new List<ArtistEvent>();

            ArtistEventData.Add(new ArtistEvent
            {
                IdEvent = 1,
                IdArtist = 1,
            });

            ArtistEventData.Add(new ArtistEvent
            {
                IdEvent = 2,
                IdArtist = 2,
            });

            builder.HasData(ArtistEventData);
        }


    }
}
