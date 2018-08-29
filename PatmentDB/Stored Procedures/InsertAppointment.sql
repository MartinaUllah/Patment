CREATE procedure [dbo].[InsertAppointment]
@PatientID int, 
@StaffID varchar(150),
@AppointmentDate datetime, 
@AppointmentTimeID int
as 
begin 
insert into Appointment (PatientID, StaffID, AppointmentDate, [AppointmentTimeID])
values (@PatientID, @StaffID, @AppointmentDate, @AppointmentTimeID)  
end 
