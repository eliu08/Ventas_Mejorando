CREATE TABLE [dbo].[Productos_Servicios]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1,1),
	[Actividad] varchar (50) not null,
	[Producto] varchar (50) not null, 
    [Detalle] VARCHAR(50) NULL, 
    [Monto] DECIMAL NOT NULL, 
    [Fecha] DATETIME NOT NULL default getdate(),


)
