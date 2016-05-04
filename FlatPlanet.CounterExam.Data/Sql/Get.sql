USE [TestCounter]
GO

/****** Object:  StoredProcedure [dbo].[Get]    Script Date: 5/4/2016 9:08:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE  PROCEDURE [dbo].[Get]
(
	@Message nvarchar(500) out, 
	@IsError bit out 
)

AS
BEGIN
	BEGIN TRY
		SELECT CounterField FROM CounterTable WHERE Id=1;
		SET @Message = 'Success';
		SET @IsError = 0;
	END TRY
	BEGIN CATCH
		SET @Message = ERROR_MESSAGE() + ' ' + ERROR_LINE();
		SET @IsError = 1;
	END CATCH

END

GO


