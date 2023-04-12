using Microsoft.AspNetCore.Mvc;

namespace Proyectotw.Models
{
    public class Materia 
    {
        public Guid Id { get; set; }
        public int NRC { get; set; }
        public string Maestro { get; set; }
        public int Cant_Alumnos { get; set; }
    }
}
