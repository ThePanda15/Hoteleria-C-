using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassSuiteStandar:ClassHabitaciones
    {
        public DateTime fecha;

        public ClassSuiteStandar()
        {
            costoHabitacion = 1500;
            numHabitaciones = 1;
        }

        public override float GetDescuento()
        {
            //Aqui se indica que si el dia que se introdujo es martes o jueves se le hare un pequeño descuento al huesped
            if (dia == "Martes"||dia=="Jueves")
            {
                float costoDescuento = GetCosto() * .10f;
                return costoDescuento;

            }
            else
            {
                return 0;
            }
        }
        public override string Informacion()
        {
            return "-->Pequeña sala\n-->Finamente decorada\n-->Cuenta con jacuzzi\n-->Dos camas tipo queen size\n-->Vista a la playa ";
        }
    }
}
