CREATE TABLE [dbo].[Staff]
(
	[StaffID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FirstName] [varchar](150) NOT NULL,
	[LastName] [varchar](150) NOT NULL,
	[StartDate] [date] NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[StaffTypeID] [int] NOT NULL, 
	CONSTRAINT Fk_Staff_StaffType Foreign Key (StaffTypeID) References StaffType(StaffTypeID)
)


