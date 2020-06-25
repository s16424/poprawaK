using kolokwium3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>

    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            var ArtistData = new List<Artist>();

            ArtistData.Add(new Artist
            {
                IdArtist =1,
                Nickname = "Ania"
            });

            ArtistData.Add(new Artist
            {
                IdArtist = 2,
                Nickname = "Przemek"
            });

            builder.HasData(ArtistData);
        }

    
    }
    }

