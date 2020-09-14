using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassSuiteEjecutiva:ClassHabitaciones
    {
        public DateTime fecha;

        public ClassSuiteEjecutiva()
        {
            costoHabitacion = 1500;
            numHabitaciones = 1;
        }

        public override float GetDescuento()
        {

            //Aqui se indica que si el dia que se introdujo es domingo se le hare un pequeño descuento al huesped
            if (dia == "Domingo")
            {
                float costoDescuento = GetCosto() * .05f;
                return costoDescuento;

            }
            else
            {
                return 0;
            }
        }
        public override string Informacion()
        {
            return "-->Sala privada para reuniones\n-->Baño de visitas\n-->Conexion permanente a internet (ADSL y Wi-Fi)\n-->Incluye un pequeño bar";
        }

    }
}
