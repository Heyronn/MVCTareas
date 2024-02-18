using Microsoft.EntityFrameworkCore;
using TareasMVC.Entidades;

namespace TareasMVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //APIFuente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Con este parametro se pueden configurar las entidades y sus atributos
            //modelBuilder.Entity<Tarea>().Property(t => t.Titulo).HasMaxLength(250).IsRequired();
        }

        //Establecemos que la clase Tarea es una entidad
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        public DbSet<ArchivoAdjunto> ArchivoAdjuntos { get; set; }
    }
}
