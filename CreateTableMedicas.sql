CREATE TABLE Pacientes (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    FechaNacimiento DATE,
    Sexo NVARCHAR(10),
    Direcci�n NVARCHAR(200),
    Tel�fono NVARCHAR(20)
);

CREATE TABLE Medicos (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Especialidad NVARCHAR(100),
    Tel�fono NVARCHAR(20)
);

CREATE TABLE CitasMedicas (
    Id INT PRIMARY KEY IDENTITY,
    FechaHora DATETIME,
    PacienteId INT FOREIGN KEY REFERENCES Pacientes(Id),
    MedicoId INT FOREIGN KEY REFERENCES Medicos(Id),
    Descripci�n NVARCHAR(MAX)
);
