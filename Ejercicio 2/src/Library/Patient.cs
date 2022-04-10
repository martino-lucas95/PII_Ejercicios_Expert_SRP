using System;
using System.Text;

namespace Library
{
    public class ValidPatient
    {
        // Verificamos si los datos de contacto ingresados son válidos
        public static string Patient(string name, string id, string phoneNumber)
        {
            StringBuilder validPatient = new StringBuilder("");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
                {
                    validPatient.Append("Unable to schedule appointment, Name is required\n");
                    isValid = false;
                }
            if (string.IsNullOrEmpty(id))
            {
                validPatient.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(phoneNumber))
                {
                    validPatient.Append("Unable to schedule appointment, Phone number is required\n");
                    isValid = false;
                }
            
            if (isValid)
            {
                validPatient.Append("Valid patient data\n");
            }

            return validPatient.ToString();
        }
    }
    
}