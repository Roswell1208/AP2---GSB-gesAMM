USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_update_etpnorme]    Script Date: 06/01/2023 17:23:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[prc_update_etpnorme]

	@norme varchar(500),
	@norme_date date,
	@etp_num int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE ETAPE_NORME
	SET NORME = @norme, NORME_DATE = @norme_date
	WHERE @etp_num = ETAPE_ETP_NUM

END
