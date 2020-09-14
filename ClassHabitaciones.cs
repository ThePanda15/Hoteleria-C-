using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassHabitaciones
    {

        public string nomHabitacion;
        public float costoHabitacion;
        public float descuento;
        public float costo;
        public int numHabitaciones;
        public int dias;
        public string dia;
        public int id;
        Random folio = new Random();


        public  virtual float GetCosto()
        {
            id = folio.Next(1, 1000);
            float   costo = (costoHabitacion * dias)*numHabitaciones;
            return costo;
        }
        public virtual float GetDescuento()
        {
            if (dia == "Viernes")
            {
                float costoDescuento = GetCosto() * descuento;
                return costoDescuento;

            }
            else
            {
                return 0;
            }
        }

        public virtual string Informacion()
        {
            return "Informaicon detallada sobre las habitacione";
        }

    }
}
