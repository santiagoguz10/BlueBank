using BlueBank.Context;
using BlueBank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.Controllers.CuentaController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarCuentaController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ConsultarCuentaController(AppDbContext context)
        {
            _context = context;
        }


        #region Listar Cuentas
        // GET: api/<CuentaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuenta>>> GetCuentas()
        {
            return await _context.Cuenta.ToListAsync();
        }

        #endregion
        #region Listar saldo Cuenta por número
        // GET: api/<CuentaController>
        [HttpGet("{id}")]
        public async Task<ActionResult<Cuenta>> GetCuentas(int id)
        {
            var cuenta = await _context.Cuenta.FindAsync(id);

            if (cuenta == null)
            {
                return NotFound();
            }
            return cuenta;
        }
        #endregion
    }
}
