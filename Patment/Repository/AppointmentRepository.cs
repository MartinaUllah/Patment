using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patment.Models;
using Dapper;
using System.Data;
using System.Web.Mvc;


namespace Patment.Repository
{
    public class AppointmentRepository
    {
        public List<SelectListItem> GetAllStaff()
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var AllStaff = connection.Query<Staff>("[dbo].[GetAllStaff]", commandType: CommandType.StoredProcedure);

                    var staffList = new List<SelectListItem>();

                    foreach (var oneStaff in AllStaff)
                    {
                        var selectListItem = new SelectListItem();
                        selectListItem.Text = oneStaff.LastName;
                        selectListItem.Value = oneStaff.StaffID.ToString();

                        staffList.Add(selectListItem);
                    }

                    return staffList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<SelectListItem> GetAllAppointments()
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var AllAppointmentTimes = connection.Query<AppointmentTime>("[dbo].[GetAllAppointments]",
                        commandType: CommandType.StoredProcedure);

                    var appointmentList = new List<SelectListItem>();

                    foreach (var oneAppointmentTime in AllAppointmentTimes)
                    {
                        var selectListItem = new SelectListItem();
                        selectListItem.Text = oneAppointmentTime.AppointmentDescription;
                        selectListItem.Value = oneAppointmentTime.AppointmentTimeID.ToString();

                        appointmentList.Add(selectListItem);
                    }

                    return appointmentList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void InsertAppointment(Appointment appointment)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    connection.Query("[dbo].[InsertAppointment]",
                       new
                       {
                           PatientID = appointment.PatientID,
                           StaffID = appointment.SelectedStaff,
                           AppointmentDate = appointment.AppointmentDate,
                           AppointmentTimeID = appointment.SelectedAppointmentTime
                       },

                       commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}





