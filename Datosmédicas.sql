-- Datos de ejemplo para la tabla Pacientes
INSERT INTO Pacientes (Nombre, Apellido, FechaNacimiento, Sexo, Direcci�n, Tel�fono)
VALUES ('Juan', 'P�rez', '1980-05-15', 'Masculino', 'Calle 123, Ciudad X', '123456789'),
       ('Mar�a', 'G�mez', '1995-08-22', 'Femenino', 'Avenida 456, Ciudad Y', '987654321'),
       ('Carlos', 'Mart�nez', '1976-11-10', 'Masculino', 'Plaza Principal, Ciudad Z', '456789123');

-- Datos de ejemplo para la tabla Medicos
INSERT INTO Medicos (Nombre, Apellido, Especialidad, Tel�fono)
VALUES ('Ana', 'L�pez', 'Pediatr�a', '111222333'),
       ('Jos�', 'Garc�a', 'Cardiolog�a', '444555666'),
       ('Laura', 'Rodr�guez', 'Dermatolog�a', '777888999');

-- Datos de ejemplo para la tabla CitasMedicas
INSERT INTO CitasMedicas (FechaHora, PacienteId, MedicoId, Descripci�n)
VALUES ('2024-05-05 10:00:00', 1, 1, 'Control de rutina'),
       ('2024-05-06 14:30:00', 2, 2, 'Consulta por dolor en el pecho'),
       ('2024-05-07 09:15:00', 3, 3, 'Revisi�n de piel');
