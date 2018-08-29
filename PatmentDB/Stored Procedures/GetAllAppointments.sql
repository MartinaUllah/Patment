CREATE procedure [dbo].[GetAllAppointments] 
as 
begin 
select AppointmentTimeID, [AppointmentDescription]
from [dbo].[AppointmentTime]
end
