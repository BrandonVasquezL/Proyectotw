using Microsoft.AspNetCore.Mvc;

namespace Proyectotw.Models
{
    public class Alumno 
    {
        public Guid Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido  { get; set; }
        public int NRC { get; set; }
    }
}
