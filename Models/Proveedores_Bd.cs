using System.ComponentModel.DataAnnotations;

namespace recibosBack.Models
{
    public class Proveedores_Bd
    {
        [Key]
        public int CLA_PROVEEDOR { get; set; }
        public string? NOM_PROVEEDOR { get; set; }
    

    }
}
