using kolokwium3.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium3.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistEvent> ArtistEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventOrganiser> EventOrganisers { get; set; }
        public DbSet<Organiser> Organisers { get; set; }
        public MyDbContext(DbContextOptions options):base(options)
            {
            }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<ArtistEvent>().HasKey(x =>
            new
            {
                x.IdArtist,
                x.IdEvent
            });

            modelBuilder.Entity<EventOrganiser>().HasKey(x =>
new
{
    x.IdEvent,
    x.IdOrganiser
});

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistEventConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());

        }
    }
}
