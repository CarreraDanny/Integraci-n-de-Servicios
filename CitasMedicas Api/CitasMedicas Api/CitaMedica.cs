using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas_Api
{
    public class CitaMedica
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [ForeignKey("Paciente")]
        public int? PacienteId { get; set; }  // Haciendo el ID nullable
        public Paciente? Paciente { get; set; }  // Haciendo la propiedad de navegación nullable

        [ForeignKey("Medico")]
        public int? MedicoId { get; set; }  // Haciendo el ID nullable
        public Medico? Medico { get; set; }  // Haciendo la propiedad de navegación nullable

        [MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;

    }

}
