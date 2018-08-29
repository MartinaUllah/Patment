CREATE procedure [dbo].[GetOneStaff]
@StaffID int
as 
begin 
select StaffID, FirstName, LastName, Startdate, DateOfBirth, StaffTypeID 
from Staff where StaffID = @StaffID
end