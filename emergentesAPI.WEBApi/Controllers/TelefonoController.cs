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
            _telefonoService = telefonoService;
        }
    }

    [HttpPost]
    [Route("agregar")]
    public IActionResult Agregar(string Nombre, string NumeroTelefonico)
    {
        var nuevoTelefono = _telefonoService.CrearUsuario(Nombre, NumeroTelefonico);

        return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevoTelefono.IdTelefono }, nuevoTelefono);
    }


    [HttpDelete]
    [Route("eliminar")]
    public IActionResult Eliminar(int id)
    {
        var telefono = _telefonoService.ObtenerTelefonoPorId(id);
        if (telefono == null)
        {
            return NotFound();
        }
        _telefonoService.Eliminar(id);

        return NoContent();
    }


}
