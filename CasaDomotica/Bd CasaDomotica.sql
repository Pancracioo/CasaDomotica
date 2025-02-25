Create CasaDomotica;
GO

Use CasaDomotica
GO


CREATE TABLE Usuarios (
    Usuario Varchar(20),
    Contrasena VARCHAR(255) NOT NULL
);



INSERT INTO Usuarios (Usuario, Contrasena) 
VALUES ('Admin', 'admin1234');