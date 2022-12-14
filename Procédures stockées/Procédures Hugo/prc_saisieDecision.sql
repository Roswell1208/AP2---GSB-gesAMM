USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_saisieDecision]    Script Date: 07/01/2023 14:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure met à jour la table WORKFLOW et FAMILLE après saisie de la décision d'une étape par l'utilisateur
-- =============================================
ALTER PROCEDURE [dbo].[prc_saisieDecision](@medDepotLegal as varchar(5000), @numEtape as int, @idDecision as int, @dateDecision as DateTime)
AS
BEGIN
	SET NOCOUNT ON;

	declare @nbMedFam as int
	declare @nbMedFamMax as int

    if(@numEtape = 8)
	begin
		select @nbMedFam = count(*)
		from WORKFLOW W
		inner join MEDICAMENT M on M.MED_DEPOTLEGAL = W.WRK_MED_DEPOT
		where WRK_ETP_NUM = 8
		and FAM_MED_CODE in (select FAM_CODE from FAMILLE F inner join MEDICAMENT M on M.FAM_MED_CODE = F.FAM_CODE where MED_DEPOTLEGAL = @medDepotLegal)
		
		select @nbMedFamMax = FAM_NB_MEDI_AMM from FAMILLE F inner join MEDICAMENT M on M.FAM_MED_CODE = F.FAM_CODE where MED_DEPOTLEGAL = @medDepotLegal

		/* Si on ne dépasse pas le nombre de médicament max par famille */
		if((@nbMedFam + 1) <= @nbMedFamMax and @idDecision = 1)
		begin
			/* On insert dans la table Workflow */
			insert into WORKFLOW
			values(@medDepotLegal, @numEtape, @idDecision, @dateDecision)

			print 'Etape mise à jour avec succès'
		end


		else
		begin
			print 'Erreur, le nombre de médicament par famille est dépassé'
		end
	end

	else
	begin
		/* On insert dans la table Workflow */
		insert into WORKFLOW
		values(@medDepotLegal, @numEtape, @idDecision, @dateDecision)

		print 'Etape mise à jour avec succès'
	end
END
