CREATE procedure [dbo].[InsertStaff]
@FirstName varchar(150), 
@LastName varchar(150),
@StartDate datetime,
@DateOfBirth datetime,
@StaffTypeID int
as 
begin 
insert into Staff (FirstName, LastName, StartDate, DateOfBirth, StaffTypeID)
values (@FirstName, @LastName, @StartDate, @DateOfBirth, @StaffTypeID)
end