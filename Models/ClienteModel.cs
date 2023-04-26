using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1er_Parcial_BlasServin_Optativo4.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        //public CiudadModel? IdCiudad { get; set; }
        [ForeignKey("IdCiudad")]
        public int IdCiudad { get; set; }
        public CiudadModel? Ciudad { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        public string? Documento { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? FechaNacimiento { get; set; }
        [Required]
        //public string? Ciudad { get; set; }
        public string? Nacionalidad { get; set; }
    }
}
