CREATE procedure [dbo].[GetOnePatient]
@PatientID int
as 
begin 
select PatientID, FirstName, LastName, DateOfBirth, NhsNumber from Patient where PatientID = @PatientID 
end
