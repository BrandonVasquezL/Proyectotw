using Proyectotw.Data;
using Proyectotw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proyectotw.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MateriasController : Controller
    {
        private readonly BDContext _dbContext;
        public MateriasController(BDContext bDContext)
        {
            _dbContext = bDContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMaterias()
        {
            var materias = await _dbContext.Materias.ToListAsync();

            return Ok(materias);
        }

        [HttpPost]
        public async Task<IActionResult> agregarMateria([FromBody] Materia materiaRequest)
        {
            materiaRequest.Id = Guid.NewGuid();
            await _dbContext.Materias.AddAsync(materiaRequest);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetMateria([FromRoute] Guid id)
        {
            var materia = await _dbContext.Materias.FirstOrDefaultAsync(x => x.Id == id);
            if (materia == null)
            {
                return NotFound();
            }

            return Ok(materia);

        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> actualizarMateria([FromRoute] Guid id, Materia actualizarMateriaRequest)
        {
            var materia = await _dbContext.Materias.FindAsync(id);
            if (materia == null)
            {
                return NotFound();
            }

            materia.Id = actualizarMateriaRequest.Id;
            materia.NRC = actualizarMateriaRequest.NRC;
            materia.Maestro = actualizarMateriaRequest.Maestro ;
            materia.Cant_Alumnos = actualizarMateriaRequest.Cant_Alumnos;

            await _dbContext.SaveChangesAsync();

            return Ok(materia);

        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> borrarMateria([FromRoute] Guid id)
        {
            var materia = await _dbContext.Materias.FindAsync(id);
            if (materia == null)
            {
                return NotFound();

            }

            _dbContext.Materias.Remove(materia);
            await _dbContext.SaveChangesAsync();
            return Ok(materia);

        }

    }

}