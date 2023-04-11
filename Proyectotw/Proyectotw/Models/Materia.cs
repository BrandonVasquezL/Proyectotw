using Microsoft.AspNetCore.Mvc;

namespace Proyectotw.Models
{
    public class Materia : Controller
    {
        public int NRC { get; set; }
        public string Maestro { get; set; }
        public int Cant_Alumnos { get; set; }
    }
}
