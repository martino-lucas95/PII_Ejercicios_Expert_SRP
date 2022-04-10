using System;
using System.Text;

namespace Library
{
    public class ValidDoctor
    {
        // Verificamos si los datos del doctor ingresados son válidos
        public static string Doctor(string doctorName)
        {
            StringBuilder validDoctor = new StringBuilder("");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(doctorName))
            {
                validDoctor.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }
            if (isValid)
            {
                validDoctor.Append("Valid doctor data\n");
            }

            return validDoctor.ToString();
        }
    }
}