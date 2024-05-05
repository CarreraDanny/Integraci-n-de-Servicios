using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CitasMedicas_Api
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;  

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; }= string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [MaxLength(10)]
        public string Sexo { get; set; }=string.Empty;

        [MaxLength(200)]
        public string Direccion { get; set; } =string.Empty;

        [MaxLength(20)]
        public string Telefono { get; set; } = string.Empty;
    }
}
