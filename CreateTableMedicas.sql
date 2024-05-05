CREATE TABLE Pacientes (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    FechaNacimiento DATE,
    Sexo NVARCHAR(10),
    Dirección NVARCHAR(200),
    Teléfono NVARCHAR(20)
);

CREATE TABLE Medicos (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Especialidad NVARCHAR(100),
    Teléfono NVARCHAR(20)
);

CREATE TABLE CitasMedicas (
    Id INT PRIMARY KEY IDENTITY,
    FechaHora DATETIME,
    PacienteId INT FOREIGN KEY REFERENCES Pacientes(Id),
    MedicoId INT FOREIGN KEY REFERENCES Medicos(Id),
    Descripción NVARCHAR(MAX)
);
