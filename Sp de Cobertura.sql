USE [ProyectoProgra6]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ModificarCobertura]
		  @idCoberturaPoliza int,
		  @Nombre varchar(50),          
          @Descripcion varchar(50),          
          @Porcentaje decimal
AS
BEGIN
	UPDATE CoberturaPolizas
	SET Nombre=@Nombre,
	Descripcion=@Descripcion,
	Porcentaje=@Porcentaje
	WHERE idCoberturaPoliza=@idCoberturaPoliza
END
GO

CREATE PROCEDURE [dbo].[sp_getCoberturaPolizasEditar]
				@idCoberturaPoliza int
AS
BEGIN
SELECT * FROM CoberturaPolizas
WHERE idCoberturaPoliza= @idCoberturaPoliza
END;
GO


CREATE PROCEDURE [dbo].[sp_getCoberturaPolizas]
AS
SELECT * FROM CoberturaPolizas
GO

CREATE PROCEDURE [dbo].[sp_eliminarCobertura]
		@idCoberturaPoliza INT
AS
BEGIN
	DELETE FROM CoberturaPolizas
	WHERE idCoberturaPoliza=@idCoberturaPoliza
END
GO


CREATE PROCEDURE [dbo].[sp_AgregarCobertura]
          @Nombre varchar(50),          
          @Descripcion varchar(50),
		  @Porcentaje decimal
AS
BEGIN
	INSERT INTO [dbo].CoberturaPolizas
           (Nombre
           ,Descripcion
		   ,Porcentaje)
     VALUES
           (@Nombre,
            @Descripcion,
			@Porcentaje)
END
GO

