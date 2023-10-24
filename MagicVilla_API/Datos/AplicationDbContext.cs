using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class AplicationDbContext :DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Villa> Villas {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                { 
                    Id=1,
                    Nombre="VillaDuran",
                    Detalle="Linda Villa a Las Afueras De Medellin",
                    ImagenUrl="",
                    Ocupantes=15,
                    MetrosCuadrados=300,
                    Tarifa=3000000,
                    Amenidad="",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                 new Villa()
                 {
                     Id = 2,
                     Nombre = "VillaDuran2",
                     Detalle = "Linda Villa a Las Afueras De Pereira",
                     ImagenUrl = "",
                     Ocupantes = 15,
                     MetrosCuadrados = 200,
                     Tarifa = 2000000,
                     Amenidad = "",
                     FechaCreacion = DateTime.Now,
                     FechaActualizacion = DateTime.Now
                 }
            );
        }

    }
}
