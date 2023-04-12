using Proyectotw.Data;
using Proyectotw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proyectotw.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : Controller
    {
        private readonly BDContext _dbContext;
        public AlumnosController(BDContext bDContext)
        {
            _dbContext = bDContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAlumnos()
        {
            var estudiantes = await _dbContext.Alumnos.ToListAsync();

            return Ok(estudiantes);
        }

        [HttpPost]
        public async Task<IActionResult> agregarEstudiante([FromBody] Alumno estudianteRequest)
        {
            estudianteRequest.Id = Guid.NewGuid();
            await _dbContext.Alumnos.AddAsync(estudianteRequest);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetEstudiante([FromRoute] Guid id)
        {
            var estudiante = await _dbContext.Alumnos.FirstOrDefaultAsync(x => x.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }

            return Ok(estudiante);

        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> actualizarEstudiante([FromRoute] Guid id, Alumno actualizarEstudianteRequest)
        {
            var alumno = await _dbContext.Alumnos.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }

            alumno.Matricula = actualizarEstudianteRequest.Matricula;
            alumno.Nombre = actualizarEstudianteRequest.Nombre;
            alumno.Apellido = actualizarEstudianteRequest.Apellido;
            alumno.NRC = actualizarEstudianteRequest.NRC;

            await _dbContext.SaveChangesAsync();

            return Ok(alumno);

        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> borrarEstudiante([FromRoute] Guid id)
        {
            var estudiante = await _dbContext.Alumnos.FindAsync(id);
            if (estudiante == null)
            {
                return NotFound();

            }

            _dbContext.Alumnos.Remove(estudiante);
            await _dbContext.SaveChangesAsync();
            return Ok(estudiante);

        }

    }

}