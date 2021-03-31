using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.Models
{
    public class Cuenta
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName ="varchar(100)")]
        public string nombreTitular { get; set; }
        [Required]
        public int valorInicial { get; set; }
        [Required]
        public int saldo { get; set; }
        public int valorConsignar { get; set; }
        public int valorRetirar { get; set; }

    }
}
