USE [master]
GO
/****** Object:  Database [AlmacenTecno]    Script Date: 9/7/2021 22:03:55 ******/
CREATE DATABASE [AlmacenTecno]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AlmacenTecno', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AlmacenTecno.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AlmacenTecno_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AlmacenTecno_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AlmacenTecno] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AlmacenTecno].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AlmacenTecno] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AlmacenTecno] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AlmacenTecno] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AlmacenTecno] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AlmacenTecno] SET ARITHABORT OFF 
GO
ALTER DATABASE [AlmacenTecno] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AlmacenTecno] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AlmacenTecno] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AlmacenTecno] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AlmacenTecno] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AlmacenTecno] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AlmacenTecno] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AlmacenTecno] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AlmacenTecno] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AlmacenTecno] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AlmacenTecno] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AlmacenTecno] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AlmacenTecno] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AlmacenTecno] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AlmacenTecno] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AlmacenTecno] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AlmacenTecno] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AlmacenTecno] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AlmacenTecno] SET  MULTI_USER 
GO
ALTER DATABASE [AlmacenTecno] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AlmacenTecno] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AlmacenTecno] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AlmacenTecno] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AlmacenTecno] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AlmacenTecno] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AlmacenTecno', N'ON'
GO
ALTER DATABASE [AlmacenTecno] SET QUERY_STORE = OFF
GO
USE [AlmacenTecno]
GO
/****** Object:  Table [dbo].[catArticulos]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catArticulos](
	[idArticulo] [int] IDENTITY(1,1) NOT NULL,
	[nombreArticulo] [varchar](100) NOT NULL,
	[categoria] [varchar](100) NOT NULL,
	[idProveedores] [int] NOT NULL,
	[idMarca] [int] NOT NULL,
 CONSTRAINT [PK__catArtic__AABB742234E332CB] PRIMARY KEY CLUSTERED 
(
	[idArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catEmpleados]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catEmpleados](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[numCedula] [varchar](30) NOT NULL,
	[primerNombre] [varchar](30) NOT NULL,
	[primerApellido] [varchar](30) NOT NULL,
	[fechaEntrada] [date] NULL,
 CONSTRAINT [PK__catEmple__5295297CB07D672A] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catMarcas]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catMarcas](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[nombreMarca] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catProveedores]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catProveedores](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombreProveedor] [varchar](100) NOT NULL,
	[correo] [varchar](100) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[ciudad] [varchar](30) NOT NULL,
 CONSTRAINT [PK_catProveedores] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClientes]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[numCedula] [varchar](30) NOT NULL,
	[primerNombre] [varchar](30) NOT NULL,
	[primerApellido] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCompras]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCompras](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[idProveedor] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idArticulo] [int] NOT NULL,
	[cantidad] [decimal](18, 0) NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[iva] [decimal](18, 0) NOT NULL,
	[descuento] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_tblCompras] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsuarios]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](32) NOT NULL,
 CONSTRAINT [PK_tblUsuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVentas]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVentas](
	[idVentas] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idArticulo] [int] NULL,
	[cantidad] [decimal](18, 0) NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[iva] [decimal](18, 0) NOT NULL,
	[descuento] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK__facturaV__A6C618C91B44E476] PRIMARY KEY CLUSTERED 
(
	[idVentas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[catArticulos] ON 

INSERT [dbo].[catArticulos] ([idArticulo], [nombreArticulo], [categoria], [idProveedores], [idMarca]) VALUES (1, N'Computadora personal', N'PC', 1, 1)
SET IDENTITY_INSERT [dbo].[catArticulos] OFF
GO
SET IDENTITY_INSERT [dbo].[catEmpleados] ON 

INSERT [dbo].[catEmpleados] ([idEmpleado], [numCedula], [primerNombre], [primerApellido], [fechaEntrada]) VALUES (1, N'0412405001004P', N'Endersson', N'Mendoza', CAST(N'2021-07-08' AS Date))
SET IDENTITY_INSERT [dbo].[catEmpleados] OFF
GO
SET IDENTITY_INSERT [dbo].[catMarcas] ON 

INSERT [dbo].[catMarcas] ([idMarca], [nombreMarca]) VALUES (1, N'Lenovo')
SET IDENTITY_INSERT [dbo].[catMarcas] OFF
GO
SET IDENTITY_INSERT [dbo].[catProveedores] ON 

INSERT [dbo].[catProveedores] ([idProveedor], [nombreProveedor], [correo], [telefono], [ciudad]) VALUES (1, N'Comtech', N'comtech@comtech.com', N'547555', N'Jinotepe')
SET IDENTITY_INSERT [dbo].[catProveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[tblClientes] ON 

INSERT [dbo].[tblClientes] ([idCliente], [numCedula], [primerNombre], [primerApellido]) VALUES (1, N'04124050010074P', N'Oswald ', N'Balladares')
SET IDENTITY_INSERT [dbo].[tblClientes] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUsuarios] ON 

INSERT [dbo].[tblUsuarios] ([idUsuario], [Nombre], [Apellido], [Usuario], [Password]) VALUES (1, N'Endersson', N'Mendoza', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[tblUsuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__catEmple__3012A775F3E96E51]    Script Date: 9/7/2021 22:03:57 ******/
ALTER TABLE [dbo].[catEmpleados] ADD  CONSTRAINT [UQ__catEmple__3012A775F3E96E51] UNIQUE NONCLUSTERED 
(
	[numCedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tblClien__3012A775BC84B599]    Script Date: 9/7/2021 22:03:57 ******/
ALTER TABLE [dbo].[tblClientes] ADD UNIQUE NONCLUSTERED 
(
	[numCedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblVentas] ADD  CONSTRAINT [DF_tblVentas_iva]  DEFAULT ((0)) FOR [iva]
GO
ALTER TABLE [dbo].[catArticulos]  WITH CHECK ADD  CONSTRAINT [FK_catArticulos_catMarcas] FOREIGN KEY([idMarca])
REFERENCES [dbo].[catMarcas] ([idMarca])
GO
ALTER TABLE [dbo].[catArticulos] CHECK CONSTRAINT [FK_catArticulos_catMarcas]
GO
ALTER TABLE [dbo].[catArticulos]  WITH CHECK ADD  CONSTRAINT [FK_catArticulos_catProveedores] FOREIGN KEY([idProveedores])
REFERENCES [dbo].[catProveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[catArticulos] CHECK CONSTRAINT [FK_catArticulos_catProveedores]
GO
ALTER TABLE [dbo].[tblCompras]  WITH CHECK ADD  CONSTRAINT [FK_tblCompras_catArticulos] FOREIGN KEY([idArticulo])
REFERENCES [dbo].[catArticulos] ([idArticulo])
GO
ALTER TABLE [dbo].[tblCompras] CHECK CONSTRAINT [FK_tblCompras_catArticulos]
GO
ALTER TABLE [dbo].[tblCompras]  WITH CHECK ADD  CONSTRAINT [FK_tblCompras_catEmpleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[catEmpleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[tblCompras] CHECK CONSTRAINT [FK_tblCompras_catEmpleados]
GO
ALTER TABLE [dbo].[tblCompras]  WITH CHECK ADD  CONSTRAINT [FK_tblCompras_catProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[catProveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[tblCompras] CHECK CONSTRAINT [FK_tblCompras_catProveedores]
GO
ALTER TABLE [dbo].[tblVentas]  WITH CHECK ADD  CONSTRAINT [FK_tblVentas_catArticulos] FOREIGN KEY([idArticulo])
REFERENCES [dbo].[catArticulos] ([idArticulo])
GO
ALTER TABLE [dbo].[tblVentas] CHECK CONSTRAINT [FK_tblVentas_catArticulos]
GO
ALTER TABLE [dbo].[tblVentas]  WITH CHECK ADD  CONSTRAINT [FK_tblVentas_catEmpleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[catEmpleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[tblVentas] CHECK CONSTRAINT [FK_tblVentas_catEmpleados]
GO
ALTER TABLE [dbo].[tblVentas]  WITH CHECK ADD  CONSTRAINT [FK_tblVentas_tblClientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[tblClientes] ([idCliente])
GO
ALTER TABLE [dbo].[tblVentas] CHECK CONSTRAINT [FK_tblVentas_tblClientes]
GO
/****** Object:  StoredProcedure [dbo].[agregarArticulo]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[agregarArticulo](

  @nombreArticulo varchar(100),
  @categoria varchar(100),
  @idProveedores int,
  @idMarca int
  )
  as
  begin
  insert into catArticulos( nombreArticulo, categoria, idProveedores, idMarca) values( @nombreArticulo, @categoria, @idProveedores, @idMarca);
  end
GO
/****** Object:  StoredProcedure [dbo].[agregarMarca]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[agregarMarca](  
  @nombreMarca varchar(100)
  )
  as
  begin
  insert into catMarcas(nombreMarca) values(@nombreMarca);
  end
GO
/****** Object:  StoredProcedure [dbo].[borrarMarcas]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[borrarMarcas](
  @idMarca int
  )
  as
  begin
  delete from catMarcas where idMarca = @idMarca;
  end
GO
/****** Object:  StoredProcedure [dbo].[EditarArticulo]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[EditarArticulo](
  @idArticulo int,
  @nombreArticulo varchar(50),
  @categoria varchar(50),
  @idProveedor int,
  @idMarca int
  )
  as
  begin
  update catArticulos set nombreArticulo = @nombreArticulo, categoria = @categoria, idProveedores = @idProveedor, idMarca = @idMarca where idArticulo =@idArticulo;
  end
GO
/****** Object:  StoredProcedure [dbo].[editarClientes]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[editarClientes](
  @idCliente int,
  @numCedula varchar(20),
  @primerNombre varchar(50),
  @primerApellido varchar(50)
  )
  as
  begin
  update tblClientes set numCedula = @numCedula, primerNombre = @primerNombre, primerApellido = @primerApellido where idCliente = @idCliente;
  end
GO
/****** Object:  StoredProcedure [dbo].[editarEmpleado]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarEmpleado](
  @idEmpleado int,
  @numCedula varchar(20),
  @nombre varchar(50),
  @apellido varchar(50)
  )
  as
  begin
  update catEmpleados set numCedula = @numCedula, primerNombre = @nombre, primerApellido = @apellido where idEmpleado = @idEmpleado;
  end
GO
/****** Object:  StoredProcedure [dbo].[editarMarcas]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[editarMarcas](
  @idMarca int,
  @nombreMarca varchar(50)
  )
  as
  begin
  update catMarcas SET nombreMarca = @nombreMarca WHERE idMarca = @idMarca;
  end
GO
/****** Object:  StoredProcedure [dbo].[editarProveedores]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[editarProveedores](
  @idProveedor int,
  @nombreProveedor varchar(50),
  @correo varchar(50),
  @telefono varchar(20),
  @ciudad varchar(50)
  )
  as
  begin
  update catProveedores set  nombreProveedor = @nombreProveedor,
  correo = @correo, telefono = @telefono, ciudad = @ciudad where idProveedor = @idProveedor;
  end
GO
/****** Object:  StoredProcedure [dbo].[editarVenta]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  CREATE proc [dbo].[editarVenta](
  @idVentas int,
  @fecha date,
  @idCliente int,
  @idEmpleado int,
  @idArticulo int,
  @cantidad int,
  @precio decimal,
  @iva decimal,
  @descuento decimal,
  @total decimal
  )
  as
  begin
  update tblVentas set fecha = @fecha, idCliente = @idCliente, idEmpleado = @idEmpleado,
  idArticulo = @idArticulo, cantidad = @cantidad, precio = @precio, iva = @iva, descuento = @descuento,
  total = @total where idArticulo = @idArticulo;
  end
GO
/****** Object:  StoredProcedure [dbo].[insertarCliente]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[insertarCliente](
   @numCedula varchar(20),
   @primerNombre varchar(50),
   @primerApellido varchar(50)
   )
   as
   begin
   insert into tblClientes(numCedula, primerNombre, primerApellido) values(@numCedula, @primerNombre, @primerApellido)
   end
GO
/****** Object:  StoredProcedure [dbo].[insertarCompra]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[insertarCompra](
  @fecha date,
  @idProveedor int,
  @idEmpleado int,
  @idArticulo int,
  @cantidad decimal,
  @precio decimal,
  @iva decimal,
  @total decimal
  )
  as
  begin
  insert into tblCompras(fecha, idProveedor, idEmpleado, idArticulo, cantidad, precio, iva, total)
  values(@fecha, @idProveedor, @idEmpleado, @idArticulo, @cantidad, @precio, @iva, @total)
  end
GO
/****** Object:  StoredProcedure [dbo].[insertarEmpleado]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarEmpleado](

@numCedula varchar(30),
@primerNombre varchar(30),
@primerApellido varchar(30),
@fechaEntrada date
)
as
begin
insert into catEmpleados( numCedula, primerNombre, primerApellido, fechaEntrada) values( @numCedula, @primerNombre, @primerApellido, @fechaEntrada)
end
GO
/****** Object:  StoredProcedure [dbo].[insertarProveedor]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[insertarProveedor](

 @nombreProveedor varchar(50),
 @correo varchar(100),
 @telefono varchar(20),
 @ciudad varchar(50)
 )
 as
 begin
 insert into catProveedores( nombreProveedor, correo, telefono, ciudad) values( @nombreProveedor, @correo, @telefono, @ciudad)
 end
GO
/****** Object:  StoredProcedure [dbo].[insertarVenta]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[insertarVenta](
   @fecha date,
  @idCliente int,
  @idEmpleado int,
  @idArticulo int,
  @cantidad decimal,
  @precio decimal,
  @iva decimal,
  @total decimal
  )
  as
  begin
  insert into tblVentas(fecha, idCliente, idEmpleado, idArticulo, cantidad, precio, iva, total)
  values(@fecha, @idCliente, @idEmpleado, @idArticulo, @cantidad, @precio, @iva, @total)
  end
GO
/****** Object:  StoredProcedure [dbo].[MostrarMarcas]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[MostrarMarcas]
 as
 begin
  SELECT * from catMarcas;
  end
GO
/****** Object:  StoredProcedure [dbo].[spLogueo]    Script Date: 9/7/2021 22:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[spLogueo](
  @user varchar(50),
  @password varchar(50)
  )
  as
  begin
  select Nombre, Apellido from tblUsuarios WHERE Usuario = @user and [Password] = @password;
  end
GO
USE [master]
GO
ALTER DATABASE [AlmacenTecno] SET  READ_WRITE 
GO
