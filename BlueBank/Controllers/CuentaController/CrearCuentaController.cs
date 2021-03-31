using BlueBank.Context;
using BlueBank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.Controllers.CuentaController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrearCuentaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CrearCuentaController(AppDbContext context)
        {
            _context = context;
        }

        #region Crear Cuenta
        // POST api/<CuentaController>
        [HttpPost]
        public async Task<ActionResult<Cuenta>> PostCuenta(Cuenta cuenta)
        {
            _context.Cuenta.Add(cuenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("ConsultarCuenta", new { id = cuenta.id }, cuenta);
        }
        #endregion
    }
}
