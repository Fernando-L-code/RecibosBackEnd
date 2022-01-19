using System.ComponentModel.DataAnnotations;

namespace recibosBack.Models
{
    public class Monedas_Bd
    {
        [Key]
        public int CLA_MONEDA { get; set; }
        public string? NOM_MONEDA { get; set; }
    

    }
}
