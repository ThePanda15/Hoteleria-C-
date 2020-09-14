using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassServiciosExtras
    {
        public int servExtra;
        public string NomServicio;
        public float costoTotal;
        public int Enfermeria;
        public int Surf;
        public int Lavanderia;
        public int Masaje;
        public int Vino;

        public ClassServiciosExtras()
        {
            servExtra = 0;
            Enfermeria = 1500;
            Surf = 2000;
            Lavanderia = 3000;
            Masaje = 5000;
            Vino = 10000;
            costoTotal = 0;
            NomServicio = null;
        }

        public void GetServicios()
        {

                
           
            Console.WriteLine("1.-Servicio de Enfermeria \n2.- Clases de surf\n3.- Lavanderia\n4.- Masaje\n5.- Vino espumoso\n6.- Ninguno");
            servExtra = int.Parse(Console.ReadLine());
            switch (servExtra)
            {
                case 1:
                    NomServicio = NomServicio + "Servicio de Enfermeria" + Enfermeria;
                    costoTotal = costoTotal + Enfermeria;
                    break;
                case 2:
                    NomServicio = NomServicio + "\nClases de surf" + Surf;
                        costoTotal = costoTotal +  Surf;
                    break;
                case 3:
                    NomServicio = NomServicio + "\nLavanderia" + Lavanderia;
                        costoTotal = costoTotal + Lavanderia;
                    break;


                case 4:
                    NomServicio = NomServicio + "\nMasaje" + Masaje;
                        costoTotal = costoTotal + Masaje;
                    break;
                case 5:
                    NomServicio = NomServicio + "\nVino espumoso" + Vino;
                        costoTotal = costoTotal + Vino;
                    break;
                default:
                    Console.WriteLine("Error opcion no valida");
                    break;
            }
            
        }
    }
    
}
