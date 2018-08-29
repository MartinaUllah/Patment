create procedure [dbo].[DeletePatient]
@PatientID int 
as 
begin 
delete from Patient where PatientID = @PatientID
end
