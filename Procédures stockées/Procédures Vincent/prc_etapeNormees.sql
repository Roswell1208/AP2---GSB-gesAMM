USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_etapeNormees]    Script Date: 06/01/2023 17:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[prc_etapeNormees]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT NORME, NORME_DATE, ETAPE_ETP_NUM
	FROM ETAPE_NORME
	ORDER BY NORME


END
