using System.ComponentModel.DataAnnotations;

namespace recibosBack.Models
{
    public class Usuarios_Bd
    {
        [Key]
        public int CLA_USUARIO { get; set; }
        public string? NOM_USUARIO { get; set; }
        public string? PASSWORD { get; set; }
    

    }
}
