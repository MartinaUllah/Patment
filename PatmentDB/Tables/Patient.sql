CREATE TABLE [dbo].[Patient]
(
	[PatientID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FirstName] [varchar](150) NOT NULL,
	[LastName] [varchar](150) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[NhsNumber] [int] NOT NULL
)
