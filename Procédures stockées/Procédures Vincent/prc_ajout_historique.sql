USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajout_historique]    Script Date: 06/01/2023 17:22:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[prc_ajout_historique]

	@HIST_USR varchar(50),
	@norme_av varchar(500),
	@norme_ap varchar(500),
	@ancienneDate DATE,
	@HIST_DATE_AP DATE,
	@HIST_DATE_MAJ DATE,
	@HIST_ETP_NUM int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO HISTORIQUE (HIST_USR, HIST_ETP_AV, HIST_ETP_AP, HIST_DATE_AV, HIST_DATE_AP, HIST_DATE_MAJ, HIST_ETP_NUM)
	VALUES (@HIST_USR, @norme_av, @norme_ap, @ancienneDate, @HIST_DATE_AP, @HIST_DATE_MAJ, @HIST_ETP_NUM)
END
