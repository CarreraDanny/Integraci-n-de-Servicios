using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitasMedicas_Api;  // Asegúrate de que este es el espacio de nombres correcto donde tienes definido tu DbContext
using System.Linq;
using System.Threading.Tasks;
namespace CitasMedicas_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasMedicasController : Controller
    {
        private readonly MedicasContext _context;

        public CitasMedicasController(MedicasContext context)
        {
            _context = context;
        }

        // GET: api/CitasMedicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitaMedica>>> GetCitasMedicas()
        {
            return await _context.CitasMedicas
                .Include(cm => cm.Paciente) // Incluye los detalles del paciente en la consulta
                .Include(cm => cm.Medico)  // Incluye los detalles del médico en la consulta
                .ToListAsync();
        }

        // GET: api/CitasMedicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CitaMedica>> GetCitaMedica(int id)
        {
            var citaMedica = await _context.CitasMedicas
                .Include(cm => cm.Paciente)
                .Include(cm => cm.Medico)
                .FirstOrDefaultAsync(cm => cm.Id == id);

            if (citaMedica == null)
            {
                return NotFound();
            }

            return citaMedica;
        }

        // POST: api/CitasMedicas
        [HttpPost]
        public async Task<ActionResult<CitaMedica>> PostCitaMedica(CitaMedica citaMedica)
        {
            _context.CitasMedicas.Add(citaMedica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCitaMedica", new { id = citaMedica.Id }, citaMedica);
        }

        // PUT: api/CitasMedicas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitaMedica(int id, CitaMedica citaMedica)
        {
            if (id != citaMedica.Id)
            {
                return BadRequest();
            }

            _context.Entry(citaMedica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitaMedicaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/CitasMedicas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitaMedica(int id)
        {
            var citaMedica = await _context.CitasMedicas.FindAsync(id);
            if (citaMedica == null)
            {
                return NotFound();
            }

            _context.CitasMedicas.Remove(citaMedica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitaMedicaExists(int id)
        {
            return _context.CitasMedicas.Any(e => e.Id == id);
        }
    }
}
