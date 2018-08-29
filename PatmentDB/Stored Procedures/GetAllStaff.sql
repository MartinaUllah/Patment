CREATE procedure [dbo].[GetAllStaff] 
as 
begin 
select StaffID, FirstName, LastName, StartDate,
DateOfBirth, StaffTypeID from Staff
end