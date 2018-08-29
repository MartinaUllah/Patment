create procedure [dbo].[UpdatePatient]
@PatientID int,
@FirstName varchar(150),
@LastName varchar(150),
@NhsNumber int
as
begin 
update Patient 
set		FirstName = @FirstName,
		LastName = @LastName,
		NhsNumber = @NhsNumber
where PatientID = @PatientID
end
