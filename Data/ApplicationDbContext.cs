using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyCineTime.Models;


namespace MyCineTime.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorId, am.MovieId });
        
        // movie tarafinda one to many iliski ve c# tarafinda joining table/model olmasi icin sunu yaziyorum:
        modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie)
            .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
        // aynisini actor tarafi icin de yaziyorum
        modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor)
            .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
        
        // default olarak authentication table yaratırken useful olacak çünkü manuel olarak identifier define etmek istemiyorum
        base.OnModelCreating(modelBuilder);
        
    }
    
    // her bir model icin 
    
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Actor_Movie> Actors_Movies { get; set; }
    public DbSet<Producer> Producers { get; set; }
}