USE [TestCounter]
GO

/****** Object:  Table [dbo].[CounterTable]    Script Date: 5/4/2016 9:08:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CounterTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CounterField] [int] NOT NULL CONSTRAINT [DF_CounterTable_CounterField]  DEFAULT ((0)),
 CONSTRAINT [PK_CounterTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


