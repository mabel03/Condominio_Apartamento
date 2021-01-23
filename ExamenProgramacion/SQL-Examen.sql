--Creacion de tablas 
go
--Tabla Habitantes
CREATE TABLE [dbo].[Habitantes](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](25) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Manzana] [int] NULL,
	[Edificio] [int] NULL,
	[Apto] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Habitantes]  WITH CHECK ADD  CONSTRAINT [FK_Habitantes_ApartamentoHabitantes] FOREIGN KEY([Apto])
REFERENCES [dbo].[ApartamentoHabitantes] ([CodigoApartamento])

ALTER TABLE [dbo].[Habitantes] CHECK CONSTRAINT [FK_Habitantes_ApartamentoHabitantes]

ALTER TABLE [dbo].[Habitantes]  WITH CHECK ADD  CONSTRAINT [FK_Habitantes_Edificio] FOREIGN KEY([Edificio])
REFERENCES [dbo].[EdificioHabitantes] ([CodigoEdificio])

ALTER TABLE [dbo].[Habitantes] CHECK CONSTRAINT [FK_Habitantes_Edificio]

ALTER TABLE [dbo].[Habitantes]  WITH CHECK ADD  CONSTRAINT [FK_Habitantes_ManzanaHabitantes] FOREIGN KEY([Manzana])

ALTER TABLE [dbo].[Habitantes] CHECK CONSTRAINT [FK_Habitantes_ManzanaHabitantes]

GO

--Creacion ManzanaHabitantes
CREATE TABLE [dbo].[ManzanaHabitantes](
	[CodigoManzana] [int] IDENTITY(1,1) NOT NULL,
	[Manzana] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ManzanaHabitantes] PRIMARY KEY CLUSTERED 
(
	[CodigoManzana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--Creacion EdificioHabitante
CREATE TABLE [dbo].[EdificioHabitantes](
	[CodigoEdificio] [int] IDENTITY(1,1) NOT NULL,
	[Edificio] [varchar](50) NULL,
 CONSTRAINT [PK_Edificio] PRIMARY KEY CLUSTERED 
(
	[CodigoEdificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--Creacion ApartamentoHabitantes
CREATE TABLE [dbo].[ApartamentoHabitantes](
	[CodigoApartamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Apartamento] PRIMARY KEY CLUSTERED 
(
	[CodigoApartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

---Insert de las tablas ---------

--Apartamento insertantes VALUES('AP1-01')
Insert into ApartamentoHabitantes VALUES('AP1-02')
Insert into ApartamentoHabitantes VALUES('AP1-03')

Insert into ApartamentoHabitantes VALUES('BP2-01')
Insert into ApartamentoHabitantes VALUES('BP2-02')
Insert into ApartamentoHabitantes VALUES('BP2-03')

Insert into ApartamentoHabitantes VALUES('CP3-01')
Insert into ApartamentoHabitantes VALUES('CP3-02')
Insert into ApartamentoHabitantes VALUES('CP3-03')

go 

---Edificio insert
Insert into ApartamentoHabitan
Insert into ApartamentoHabittes VALUES('Palmera 1')
Insert into ApartamentoHabitantes VALUES('Palmera 2')
Insert into ApartamentoHabitantes VALUES('Palmera 3')

go 

--ManzanaHabitantes insert
insert into manzanaHabitantes values ('Calle el limón1');
insert into manzanaHabitantes values ('Calle el limon2')
insert into manzanaHabitantes values ('Calle el limon3')
go


---Stored procedure de las tablas ---------
go

--Stored procedure COMO LO VE EL USUARIO
Create Procedure [dbo].[MostrarParaUsuario]
as
begin

Select h.Codigo, h.cedula as Cedula, h.Nombre, m.Manzana , E.Edificio, a.Nombre as Apartamento from Habitantes h 
join EdificioHabitantes E on E.CodigoEdificio = h.Edificio join ManzanaHabitantes m on h.Manzana = m.CodigoManzana JOIN ApartamentoHabitantes a  
on a.CodigoApartamento = h.Apto;

end

go

----Stored procedure LISTADO DE MANZANA
CREATE PROCEDURE ListadoManzana
@EleccionUsuario varchar(20)
AS
BEGIN
Select h.Codigo, h.cedula as Cedula, h.Nombre, m.Manzana , E.Edificio, a.Nombre as Apartamento 
FROM Habitantes h 
JOIN EdificioHabitantes E on E.CodigoEdificio = h.Edificio 
JOIN ManzanaHabitantes m on h.Manzana = m.CodigoManzana 
JOIN ApartamentoHabitantes a  on a.CodigoApartamento = h.Apto 
WHERE m.Manzana = @EleccionUsuario;

END

go

----Stored procedure LISTADO DE EDIFICIO
CREATE PROCEDURE ListadoEdificio
@EleccionUsuario varchar(20)
AS
BEGIN
Select h.Codigo, h.cedula as Cedula, h.Nombre, m.Manzana , E.Edificio, a.Nombre as Apartamento 
FROM Habitantes h 
JOIN EdificioHabitantes E on E.CodigoEdificio = h.Edificio 
JOIN ManzanaHabitantes m on h.Manzana = m.CodigoManzana 
JOIN ApartamentoHabitantes a  on a.CodigoApartamento = h.Apto 
WHERE E.Edificio = @EleccionUsuario;

END

go 

----Stored procedure Buscar
CREATE PROCEDURE BuscarHabitantes
@EleccionUsuario varchar(14)
AS
BEGIN

Select h.Codigo, h.cedula as Cedula, h.Nombre, m.Manzana , E.Edificio, a.Nombre as Apartamento 
FROM Habitantes h 
JOIN EdificioHabitantes E on E.CodigoEdificio = h.Edificio 
JOIN ManzanaHabitantes m on h.Manzana = m.CodigoManzana 
JOIN ApartamentoHabitantes a  on a.CodigoApartamento = h.Apto 
WHERE h.cedula = @EleccionUsuario;

END
