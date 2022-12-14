USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_listeTousUser]    Script Date: 06/01/2023 01:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne la liste des identifiants et des mots de passe de la table USER
-- =============================================
ALTER PROCEDURE [dbo].[prc_listeTousUser]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT identifiant, motDePasse FROM [USER]
END
