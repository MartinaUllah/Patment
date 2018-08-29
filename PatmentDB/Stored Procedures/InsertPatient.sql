CREATE procedure [dbo].[InsertPatient]
@FirstName varchar(150),
@LastName varchar(150),
@DateOfBirth date,
@NhsNumber int
as 
begin 
insert into Patient(FirstName, LastName, DateOfBirth, NhsNumber)
values (@FirstName, @LastName, @DateOfBirth, @NhsNumber)
end 
