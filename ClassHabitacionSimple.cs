using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassHabitacionSimple:ClassHabitaciones
    {
        //public string nomHabitacion;
        public DateTime fecha;

        public ClassHabitacionSimple()
        {
            costoHabitacion = 1500;
            numHabitaciones = 1;
        }

        public override float GetDescuento()
        {
            //Aqui se indica que si el dia que se introdujo es domingo o viernes se le hare un pequeño descuento al huesped
            if (dia=="Viernes"||dia=="Domingo")
            {
                float costoDescuento = GetCosto() * .15f;
                return costoDescuento;
                
            }
            else
            {
                return 0;
            }
        }
        public override string Informacion()
        {
            return "-->Contiene 2 camas matrimoniales\n-->Conexion a internet\n-->Calefaccion\n-->Vista panoramica de la ciudad";
        }

    }
}
