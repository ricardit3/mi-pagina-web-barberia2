using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_add.Servicios.Models
{
    public class clStock
    {
        [Key]
        public int IdStock { get; set; }
        public int Cantidad { get; set; }
        public int IdInsumo { get; set; }
        public int IdAlmacen { get; set; }
        public int IdIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EstadoRegistra { get; set; }
    }
}