using Microsoft.EntityFrameworkCore;
using MovieVerse.Server.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MovieVerse.Server.Data
{
    public class MovieVerseServerContext : DbContext
    {
        public MovieVerseServerContext(DbContextOptions<MovieVerseServerContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Cast>()
                .HasOne(c => c.Actor)
                .WithMany(a => a.Casts)
                .HasForeignKey(c => c.ActorId);


            modelBuilder.Entity<Cast>()
                .HasOne(c => c.Movie)
                .WithMany(m => m.Casts)
                .HasForeignKey(c => c.MovieId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Cast>()
                .HasOne(c => c.Series)
                .WithMany(s => s.Casts)
                .HasForeignKey(c => c.SeriesId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Genres)
                .WithMany(g => g.Movies);


            modelBuilder.Entity<Series>()
                .HasMany(s => s.Genres)
                .WithMany(g => g.Series);


            modelBuilder.Entity<Award>()
                .HasMany(a => a.Actors)
                .WithMany(a => a.Awards);


            modelBuilder.Entity<Award>()
                .HasMany(a => a.Movies)
                .WithMany(m => m.Awards);


            modelBuilder.Entity<Award>()
                .HasMany(a => a.Series)
                .WithMany(s => s.Awards);
        }
    }
}
