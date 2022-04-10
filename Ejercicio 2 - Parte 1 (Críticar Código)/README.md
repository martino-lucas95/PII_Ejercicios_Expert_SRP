# Análisis, crítica y planeación (parte 1)

-	AppointmentService no respeta el SRP (principio de responsabilidad única), porque posee la responsabilidad de conocer los datos del paciente, los datos del doctor, los datos de la consulta, y luego verificar que ningún dato sea empty o null. 

Para remendarlo, se decidió crear 3 clases en total: 

- Como se planteó que se podría agregar información sobre el paciente y sobre el doctor, entonces ya encontramos dos causas de cambios para la misma clase, por lo tanto necesitamos dos clases distintas (Patient y Doctor):
1. Patient
  Dicha clase conocerá los datos del paciente, y retornara si los mismo son o no válidos. Como se nombró anteriormente, al encapsular la clase, permitimos que la misma se pueda cambiar, agregando o quitando información.
2. Doctor
  Dicha clase conocerá los datos del paciente, y retornara si los mismo son o no válidos. Al igual que Patient, la clase se puede modificar sin problemas.
- Por último se crea al experto en información
3. ServiceAppointment
  La clase recibirá toda la información, y será el experto en decidir si todos los datos ingresados son válidos y la cita será programada. Para ello, verifica si el lugar es válido, luego utiliza las clases Patient y Doctor para verificar si los datos del paciente y el doctor son válidos. En caso de que los casos sean válidos, retornara un mensaje diciendo que la cita será programada, junto al número de id de la misma. De lo contrario, notificará que no pudo ser creada, mostrando en consola los datos faltantes.

** También se agrego una variable int estática a la clase, la cual contiene el número de identificación para la siguiente consulta, el cual incrementa con cada consulta nueva, permitiendo que cada cita tenga una id diferente. **
