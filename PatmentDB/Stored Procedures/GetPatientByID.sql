create procedure [dbo].[GetPatientByID]
@PatientID int
as
begin 
select FirstName, LastName, DateOfBirth, NhsNumber from Patient where PatientID = @PatientID
end
