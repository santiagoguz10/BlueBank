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
    public class RetirarCuentaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RetirarCuentaController(AppDbContext context)
        {
            _context = context;
        }

        #region Retirar
        // PUT api/<CuentaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> RetirarCuenta(int id, Cuenta cuenta)

        {

            if (id != cuenta.id)
            {

                return BadRequest();
            }

            if (cuenta.saldo < cuenta.valorRetirar)
            {
                return BadRequest();
            }

            else {

                cuenta.saldo = cuenta.saldo - cuenta.valorRetirar;
            }

            

            _context.Entry(cuenta).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        #endregion

    }
}
