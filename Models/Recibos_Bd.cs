using System.ComponentModel.DataAnnotations;

namespace recibosBack.Models
{
    public class Recibos_Bd
    {
        [Key]
        public int? CLA_RECIBO { get; set; }
        public int PROVEEDOR { get; set; }
        public double MONTO { get; set; }
        public int MONEDA { get; set; }
        public DateTime FECHA { get; set; }
        public string? COMENTARIO { get; set; }

    }
}
