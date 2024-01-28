using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace PracticoSI1.Models
{
    public class clInsumo
    {
        [Key]
        public int IdInsumo { get; set; }

        public int Codigo1 { get; set; }

        public int Codigo2 { get; set; }

        public string NombreInsumo { get; set; }

        public string Imagen { get; set; }

        public int CantidadMaxima { get; set; }

        public int CantidadMinima { get; set; }

        public decimal PrecioCompra { get; set; }

        public DateTime ConFechaVencimiento { get; set; }

        public int IdMoneda { get; set; }

        public int IdLineaArticulo { get; set; }

        public int IdGrupoArticulo { get; set; }

        public int IdUnidadMedida { get; set; }

        public int IdSerialización { get; set; }

        public int IdMarca { get; set; }

        public int IdColor { get; set; }

        public string Estante { get; set; }

        public string Nivel { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string EstadoRegistro { get; set; }

        [ForeignKey("IdUnidadMedida")]
        public clUnidadDeMedida UnidadMedida { get; set; }

        [ForeignKey("IdGrupoArticulo")]
        public cIGrupoArticulo GrupoArticulo { get; set; }
    }
}
