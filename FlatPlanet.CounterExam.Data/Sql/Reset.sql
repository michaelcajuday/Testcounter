USE [TestCounter]
GO

/****** Object:  StoredProcedure [dbo].[Reset]    Script Date: 5/4/2016 9:10:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE  PROCEDURE [dbo].[Reset]
(
	@Message nvarchar(500) out, 
	@IsError bit out 
)

AS
BEGIN
	BEGIN TRY
		UPDATE CounterTable SET CounterField = 1 WHERE Id=1;
		SET @Message = 'Count was reset';
		SET @IsError = 0;
	END TRY
	BEGIN CATCH
		SET @Message = ERROR_MESSAGE() + ' ' + ERROR_LINE();
		SET @IsError = 1;
	END CATCH
END

GO


