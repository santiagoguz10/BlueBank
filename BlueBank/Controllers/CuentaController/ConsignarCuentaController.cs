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
    public class ConsignarCuentaController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ConsignarCuentaController(AppDbContext context)
        {
            _context = context;

        }

            #region Consignar
            // PUT api/<CuentaController>/5
            [HttpPut("{id}")]
        public async Task<ActionResult> ConsignarCuenta(int id, Cuenta cuenta)

        {

            if (id != cuenta.id)
            {
                return BadRequest();
            }

            cuenta.saldo = cuenta.saldo + cuenta.valorConsignar;
            

            _context.Entry(cuenta).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion
    }
}
