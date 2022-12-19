using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades.Entidades;

namespace VideoClub.Repositorios
{
    public class VideoClubDbContext:DbContext
    {
        public VideoClubDbContext() : base("name=MiConexion")
        {
            Database.CommandTimeout = 50;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VideoClubDbContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        //dbsets es la abstraccion de las tablas en EF

        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Soporte> Soportes { get; set; }

    }
}
