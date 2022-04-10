using System;
using System.Text;

namespace Library
{   
    public class AppointmentService
    {   
        public static int idApointment = 0;
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder mesagge = new StringBuilder("Scheduling appointment...\n");

            string validPlace = "Valid Place\n";        
            if(String.IsNullOrEmpty(appoinmentPlace))
            {
                validPlace = "Unable to schedule appointment, Appoinment place is required\n";
            }
            
            string patientResult = ValidPatient.Patient(name, id, phoneNumber);
            string doctorResult = ValidDoctor.Doctor(doctorName);


            if((validPlace == "Valid Place\n") && (patientResult == "Valid patient data\n") && (doctorResult == "Valid doctor data\n"))
            {
                mesagge.Append($"Appoinment whit the id = {idApointment} Scheduled\n");
                idApointment++;               
            }
            else
            {
                mesagge.Append($"{validPlace}{patientResult}{doctorResult}");
            }

            return mesagge.ToString(); 
        }

    }
}
