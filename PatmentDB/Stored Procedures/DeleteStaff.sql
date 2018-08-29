create procedure [dbo].[DeleteStaff]
@StaffID int 
as 
begin 
delete from Staff where StaffID = @StaffID
end