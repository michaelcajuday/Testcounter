USE [TestCounter]
GO

/****** Object:  StoredProcedure [dbo].[Increm]    Script Date: 5/4/2016 9:09:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE  PROCEDURE [dbo].[Increm]
(
	@Message nvarchar(500) out, 
	@IsError bit out 
)

AS
BEGIN
	BEGIN TRY
		DECLARE @currentCount INT = (SELECT a.CounterField FROM CounterTable a);

		IF ( @currentCount < 10) BEGIN 
			UPDATE CounterTable SET CounterField = CounterField+1 WHERE Id=1;
			SET @Message = 'Incremented';
			SET @IsError = 0;
		END 
		ELSE BEGIN
			SET @Message = 'Cannot go beyond 10';
			SET @IsError = 1;
		END
	END TRY
	BEGIN CATCH
		SET @Message = ERROR_MESSAGE() + ' ' + ERROR_LINE();
		SET @IsError = 1;
	END CATCH

END

GO


