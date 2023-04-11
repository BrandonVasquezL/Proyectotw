using Microsoft.AspNetCore.Mvc;

namespace Proyectotw.Models
{
    public class Alumno : Controller
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string apellido  { get; set; }
        public int NRC { get; set; }
    }
}
