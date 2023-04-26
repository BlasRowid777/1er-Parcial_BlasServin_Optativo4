using System.ComponentModel.DataAnnotations;

namespace _1er_Parcial_BlasServin_Optativo4.Models
{
    public class CiudadModel
    {
        public int Id { get; set; }
        [Required]
        public string? Ciudad { get; set; }
        [Required]  
        public string? Estado { get; set; }
    }
}
