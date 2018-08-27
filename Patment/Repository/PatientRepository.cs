using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patment.Models;
using Dapper;
using System.Data;

namespace Patment.Repository
{
    public class PatientRepository
    {
        public void InsertPatient(Patient patient)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    connection.Query("[dbo].[InsertPatient]",
                       new
                       {
                           FirstName = patient.FirstName,
                           LastName = patient.LastName,
                           DateOfBirth = patient.DateOfBirth,
                           NhsNumber = patient.NhsNumber
                       },

                       commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Patient> AllPatients()
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Patient>("GetAllPatients", commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //Details
        public Patient PatientDetail(int patientId)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Patient>("getOnePatient",
                        new
                        {
                            PatientID = patientId
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
        public Patient GetPatientDetails(int patientID)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Patient>("[dbo].[GetPatientByID]",
                        new
                        {
                            PatientID = patientID

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

        public Patient UpdateOfPatient(Patient patient)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Patient>("[dbo].[UpdatePatient]",
                        new
                        {

                            PatientID = patient.PatientID,
                            FirstName = patient.FirstName,
                            LastName = patient.LastName,
                            NhsNumber = patient.NhsNumber
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

        public Patient DeletePatient(int PatientID)
        {
            using (var connection = SqlConnectionFactory.GetConnectionString())
            {
                try
                {
                    var result = connection.Query<Patient>("DeletePatient",
                        new
                        {
                            PatientID = PatientID

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