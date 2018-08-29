create procedure [dbo].[GetAllPatients] 
as 
begin 
select PatientID, FirstName, LastName, DateOfBirth, NhsNumber from Patient
end
