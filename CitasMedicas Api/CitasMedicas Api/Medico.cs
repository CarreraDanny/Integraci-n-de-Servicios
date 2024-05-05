namespace CitasMedicas_Api
{
    public class Medico
    {
        public int Id { get; set; }

        // Inicialización directa para asegurar que nunca sea nula
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Especialidad { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
