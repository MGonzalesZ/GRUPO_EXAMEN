using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emergentesAPI.LN;
using Microsoft.EntityFrameworkCore;

namespace emergentesAPI.WEBApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TelefonoController : ControllerBase
    {
        private readonly telefonosService _telefonosService;

        public TelefonoController(telefonosService telefonoService)
        {
            _telefonosService = telefonoService;
        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult Agregar(string nombre, string numero)
        {
            var nuevoTelefono = _telefonosService.Agregar(nombre, numero);

            return Ok(nuevoTelefono);
        }



        [HttpDelete]
        [Route("eliminar")]
        public IActionResult Eliminar(int id)
        {

        
            _telefonosService.Eliminar(id);

            return NoContent();
        }
    }


}
