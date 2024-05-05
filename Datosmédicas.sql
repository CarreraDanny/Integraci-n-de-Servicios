-- Datos de ejemplo para la tabla Pacientes
INSERT INTO Pacientes (Nombre, Apellido, FechaNacimiento, Sexo, Dirección, Teléfono)
VALUES ('Juan', 'Pérez', '1980-05-15', 'Masculino', 'Calle 123, Ciudad X', '123456789'),
       ('María', 'Gómez', '1995-08-22', 'Femenino', 'Avenida 456, Ciudad Y', '987654321'),
       ('Carlos', 'Martínez', '1976-11-10', 'Masculino', 'Plaza Principal, Ciudad Z', '456789123');

-- Datos de ejemplo para la tabla Medicos
INSERT INTO Medicos (Nombre, Apellido, Especialidad, Teléfono)
VALUES ('Ana', 'López', 'Pediatría', '111222333'),
       ('José', 'García', 'Cardiología', '444555666'),
       ('Laura', 'Rodríguez', 'Dermatología', '777888999');

-- Datos de ejemplo para la tabla CitasMedicas
INSERT INTO CitasMedicas (FechaHora, PacienteId, MedicoId, Descripción)
VALUES ('2024-05-05 10:00:00', 1, 1, 'Control de rutina'),
       ('2024-05-06 14:30:00', 2, 2, 'Consulta por dolor en el pecho'),
       ('2024-05-07 09:15:00', 3, 3, 'Revisión de piel');
