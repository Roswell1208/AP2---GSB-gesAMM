-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure ajoute un nouveau médicament dont les informations sont saisies par l'utilisateur.
--				Elle vérifie aussi le dépot légal avant insertion.
-- =============================================
ALTER PROCEDURE prc_ajoutNewMed (@medDepotLegal as varchar(5000), @nomCommercial as varchar(5000),
	@famCode as varchar(5000), @composition as varchar(5000), @effets as varchar(5000),
	@contreIndic as varchar(5000), @prixEchant as varchar(5000))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    if exists(select * from MEDICAMENT where MED_DEPOTLEGAL = @medDepotLegal)
	begin
		print ('Erreur, un médicament avec ce dépot légal existe déjà.')
		return
	end

	else
	begin
		insert into MEDICAMENT
		values (@medDepotLegal, @nomCommercial, @famCode, @composition, @effets, @contreIndic, @prixEchant)

		print ('Ajout effectué avec succès.')
		return
	end
END
GO
