using DBConnectPractice.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectPractice.Repository
{
    internal class DBContext
    {
        public class PeliculasDbContext : DbContext 
        {
            public PeliculasDbContext(DbContextOptions<PeliculasDbContext>options) : base(options)
            {

            }
            public DbSet<Peliculas> Peliculas { get; set; }
            public DbSet<Generos> Generos { get; set; }
            public DbSet<Directores> Directores { get; set; }
            public DbSet<Actuaciones> Actuaciones { get; set; }
            public DbSet<Actores> Actores { get; set; }
            public DbSet<PeliculasGeneros> PeliculasGeneros { get; set; }
            public DbSet<Productora> Productora { get; set; }
            public DbSet<Rankings> Rankings { get; set; }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Config Entity to the table "Peliculas"
                modelBuilder.Entity<Peliculas>(entity =>
                {
                    entity.ToTable("Peliculas");

                    modelBuilder.Entity<Peliculas>().HasKey(p => new
                    {
                        p.IdPelicula,
                        p.Titulo,
                        p.AñoEstreno,
                        p.Clasificacion,
                        p.IdProductora,
                        p.IdDirector,
                        p.Recaudacion
                    });

                    entity.Property(p => p.IdPelicula)
                        .HasColumnName("id_pelicula");

                    entity.Property(p => p.Titulo)
                        .HasColumnName("titulo");

                    entity.Property(p => p.AñoEstreno)
                        .HasColumnName("año_estreno");

                    entity.Property(p => p.Clasificacion)
                        .HasColumnName("clasificacion");

                    entity.Property(p => p.IdProductora)
                        .HasColumnName("id_productora");

                    entity.Property(p => p.IdDirector)
                        .HasColumnName("id_director");

                    entity.Property(p => p.Recaudacion)
                        .HasColumnName("recaudacion");


                });

                // Config Entity to the table "Generos"
                modelBuilder.Entity<Generos>(entity =>
                {
                    entity.ToTable("Generos");

                    modelBuilder.Entity<Generos>().HasKey(g => new
                    {
                        g.IdGenero,
                        g.Nombre,
                       
                    });

                    entity.Property(g => g.IdGenero)
                       .HasColumnName("id_genero");
                    
                    entity.Property(g => g.Nombre)
                        .HasColumnName("nombre");

                });

                // Config Entity to the table "Directores"
                modelBuilder.Entity<Directores>(entity =>
                {
                    entity.ToTable("Directores");

                    modelBuilder.Entity<Directores>().HasKey(d => new
                    {
                        d.IdDirector,
                        d.Nombre,
                        d.FechaNac,

                    });

                    entity.Property(d => d.IdDirector)
                        .HasColumnName("id_director");

                    entity.Property(d => d.Nombre)
                        .HasColumnName("nombre");

                    entity.Property(d => d.FechaNac)
                        .HasColumnName("fecha_nac");
                });

                // Config Entity to the table "Actuaciones"
                modelBuilder.Entity<Actuaciones>(entity =>
                {
                    entity.ToTable("Actuaciones");

                    modelBuilder.Entity<Actuaciones>().HasKey(ac => new
                    {
                        ac.IdActuacion,
                        ac.IdPelicula,
                        ac.IdActor,
                        ac.Papel,
                    });

                    entity.Property(ac => ac.IdActuacion)
                        .HasColumnName("id_actuacion");
                    entity.Property(ac => ac.IdPelicula)
                        .HasColumnName("id_pelicula");
                    entity.Property(ac => ac.IdActor)
                        .HasColumnName("id_actir");
                    entity.Property(ac => ac.Papel)
                        .HasColumnName("papel");

                });

                // Config Entity to the table "Actores"
                modelBuilder.Entity<Actores>(entity =>
                {
                    entity.ToTable("Actores");

                    modelBuilder.Entity<Actores>().HasKey(ar => new
                    {
                        ar.IdActor,
                        ar.Nombre,
                        ar.FechaNac,
                        ar.Sexo,
                    });

                    entity.Property(ar => ar.IdActor)
                        .HasColumnName("id_actor");
                    entity.Property(ar => ar.Nombre)
                        .HasColumnName("nombre");
                    entity.Property(ar => ar.FechaNac)
                        .HasColumnName("fecha_nac");
                    entity.Property(ar => ar.Sexo)
                        .HasColumnName("sexo");

                });

                // Config Entity to the table "PeliculasGeneros"
                modelBuilder.Entity<PeliculasGeneros>(entity =>
                {
                    entity.ToTable("PeliculasGeneros");

                    modelBuilder.Entity<PeliculasGeneros>().HasKey(pg => new
                    {
                        pg.IdPeliculaGenero,
                        pg.IdPelicula,
                        pg.IdGenero,
                        
                    });

                    entity.Property(pg => pg.IdPeliculaGenero)
                        .HasColumnName("id_pelicula_genero");
                    entity.Property(pg => pg.IdPelicula)
                        .HasColumnName("IdPelicula");
                    entity.Property(pg => pg.IdGenero)
                        .HasColumnName("id_genero");
             
                });

                // Config Entity to the table "Productora"
                modelBuilder.Entity<Productora>(entity =>
                {
                    entity.ToTable("Productora");

                    modelBuilder.Entity<Productora>().HasKey(pr => new
                    {
                        pr.IdProductora,
                        pr.Nombre,
                        pr.Fundacion,

                    });

                    entity.Property(pr => pr.IdProductora)
                        .HasColumnName("id_productora");
                    entity.Property(pr => pr.Nombre)
                        .HasColumnName("nombre");
                    entity.Property(pr => pr.Fundacion)
                        .HasColumnName("fundacion");

                });

                // Config Entity to the table "Rankings"
                modelBuilder.Entity<Rankings>(entity =>
                {
                    entity.ToTable("Rankings");

                    modelBuilder.Entity<Rankings>().HasKey(r => new
                    {
                        r.IdRanking,
                        r.IdPelicula,
                        r.Ranking,
                        r.Fecha

                    });

                    entity.Property(r => r.IdRanking)
                        .HasColumnName("id_ranking");
                    entity.Property(r => r.IdPelicula)
                        .HasColumnName("id_pelicula");
                    entity.Property(r => r.Ranking)
                        .HasColumnName("ranking");
                    entity.Property(r => r.Fecha)
                        .HasColumnName("fecha");

                });

                base.OnModelCreating(modelBuilder);

            }
        }
    }
}
