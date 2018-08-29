create procedure [dbo].[UpdateStaff]
@StaffID int,
@FirstName varchar(150),
@LastName varchar(150),
@StartDate datetime, 
@DateOfBirth datetime,
@StaffTypeID int
as
begin 
update Staff 
set		FirstName = @FirstName,
		LastName = @LastName,
		StartDate = @StartDate,
		DateOfBirth = @DateOfBirth,
		StaffTypeID = @StaffTypeID 
where StaffID = @StaffID
end
