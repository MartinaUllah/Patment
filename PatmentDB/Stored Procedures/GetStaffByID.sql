create procedure [dbo].[GetStaffByID]
@StaffID int
as
begin 
select FirstName, LastName, Startdate, DateOfBirth, StaffTypeID
from Staff where StaffID = @StaffID
end
