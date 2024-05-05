using Microsoft.EntityFrameworkCore;

namespace CitasMedicas_Api
{
    public class MedicasContext : DbContext
    {
        public MedicasContext(DbContextOptions<MedicasContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<CitaMedica> CitasMedicas { get; set; }
    }
}
