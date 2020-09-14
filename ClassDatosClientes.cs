using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassDatosClientes
    {
        public string nombre;
        public double telefono;
        public int edad;
        public string domicilio;
        public int habitacion;
        public int diasHospedados;
        public int numPersonas;
        public int id;
        public string tipIdentificacion;


        public ClassDatosClientes()
        {
            nombre = null;
        }

        public void Huesped()
        {
            Console.Clear();
            Console.WriteLine("*****************D A T O S    D E L    H U E S P E D***********************");
            //Se introduce el nombre completo del huesped
            Console.WriteLine("Nombre del huesped");
            
            nombre = Console.ReadLine();
           

            //Se introduce la edad del huesped
            Console.WriteLine("Ingrese su edad");
           
            edad = int.Parse(Console.ReadLine());

            //Se introduce el numero telefonico del huesped
            Console.WriteLine("Ingrese su numero telefonico");
            telefono = double.Parse(Console.ReadLine());
           

            //Se introduce el domicilio de origen del huesped
            Console.WriteLine("Ingrese el domicilio del cliente");
            domicilio = Console.ReadLine();
            


            //Para registrarse es necesario una identifacion (Credencial, Pasaporte, Tarjeta de credito)
            Console.WriteLine("Ingrese el tipo de indentificacion del huesped");
            tipIdentificacion = Console.ReadLine();
            
        }

        public void Validar()
        {
            if (numPersonas >4)

            {
                Console.WriteLine("Necesita otra habitacion");
            }
        }

    }
}
