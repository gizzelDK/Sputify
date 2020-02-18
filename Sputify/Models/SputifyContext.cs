using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sputify.Models
{
    public class SputifyContext : DbContext
    {
        public SputifyContext(DbContextOptions<SputifyContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Collection> Collections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().ToTable("Albums");
            modelBuilder.Entity<Playlist>().ToTable("Playlists");
            modelBuilder.Entity<Collection>().ToTable("Collections");
            modelBuilder.Entity<Song>().ToTable("Songs");
        }
    }
}
