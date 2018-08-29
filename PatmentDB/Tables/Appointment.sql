CREATE TABLE [dbo].[Appointment]
(
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[StaffID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[AppointmentTimeID] [int] NOT NULL,
	CONSTRAINT Fk_Appointment_Patient Foreign Key (PatientID) References Patient(PatientID)
)
