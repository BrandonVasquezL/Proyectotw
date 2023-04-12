using Proyectotw.Models;
using Microsoft.EntityFrameworkCore;

namespace Proyectotw.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}