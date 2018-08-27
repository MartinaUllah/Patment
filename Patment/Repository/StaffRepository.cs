using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patment.Models;
using Dapper;
using System.Data;

namespace Patment.Repository
{
    public class StaffRepository
    {
        public Staff InsertStaff(Staff staff)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Staff>("InsertStaff",
                        new
                        {
                            FirstName = staff.FirstName,
                            LastName = staff.LastName,
                            StartDate = staff.StartDate,
                            DateOfBirth = staff.DateOfBirth,
                            StaffTypeID = staff.StaffTypeID
                        },
                        commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Staff> GetAllStaff()
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Staff>("[dbo].[GetAllStaff]",
                        commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }
        }

        //Details
        public Staff StaffDetail(int StaffID)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Staff>("[dbo].[GetOneStaff]",
                        new
                        {
                            StaffID = StaffID
                        },
                        commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //Update
        public Staff GettingStaffDetails(int StaffID)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Staff>("[dbo].[GetStaffByID]",
                        new
                        {
                            StaffID = StaffID
                        },
                        commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //update
        public Staff UpdateOfStaff(Staff staff)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Staff>("[dbo].[UpdateStaff]",
                        new
                        {
                            StaffID = staff.StaffID,
                            FirstName = staff.FirstName,
                            LastName = staff.LastName,
                            StartDate = staff.StartDate,
                            DateOfBirth = staff.DateOfBirth,
                            StaffTypeID = staff.StaffTypeID
                        },
                        commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Staff DeleteStaff(int StaffID)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Staff>("[dbo].[DeleteStaff]",
                        new
                        {
                            StaffID = StaffID
                        },
                        commandType: CommandType.StoredProcedure);
                    return result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}