using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float costoFinal;

            int opc = 0;

            string servicios;
            //Declaramos un vector para almacenar 100 registros
            ClassDatosClientes[] informacion = new ClassDatosClientes[100];
            ClassSuiteEjecutiva ejectuvia = new ClassSuiteEjecutiva();
            ClassServiciosExtras extras = new ClassServiciosExtras();
            ClassHabitaciones habitaciones = new ClassHabitaciones();
            ClassDatosClientes datos = new ClassDatosClientes();
            ClassHabitacionSimple simple = new ClassHabitacionSimple();
            ClassSuiteStandar standar = new ClassSuiteStandar();
            //Aqui comenzamos un vector donde el usuario solo podra ingresar 100 registros por dias
            for (int i = 0; i < informacion.Length; i++)
            {
                //La opcion SetCursorPosition nos sirve para posicionar el texto en cierta area de la consola
                Console.SetCursorPosition(32, 1); Console.WriteLine("Registro N°" + (i+1));
                
                Console.WriteLine("Seleccione la opcion deseada");
                Console.WriteLine("1.-Habitacion simple \n2.- Suite Standar \n3.- Suite Ejectuvia\n4.- Informacion");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        //Una vez tecleado 1 se añadira a la variable de nombre de habitacion a nuestra clase ClassHabitacionSimple
                        simple.nomHabitacion = "Habitacion simple";
                        //Aqui mandamos llamar a nuestro metodo que se encuentra en la clase ClassDatosClientes
                        datos.Huesped();

                        //Una vez llenados los datos pasaremos a indicar cuantos dias estaremos hospedados
                        Console.WriteLine("Cuantos dias desea hospedarse?");

                        simple.dias = int.Parse(Console.ReadLine());
                        //En este aparte el usuario escribira el dia ya que hay ciertos dias donde se realiza un descuento
                        Console.WriteLine("Escribe el dia de registro");
                        simple.dia = Console.ReadLine();
                        //En este apartado preguntaremos al huesped si desea algun servicio extra 
                        Console.WriteLine("Desea algun servicio extra?");
                        servicios = Console.ReadLine();
                        if (servicios=="Si"||servicios=="si")
                        {
                            extras.NomServicio = "";
                            extras.GetServicios();
                            Console.WriteLine("**********************Datos del cliente*******************************");
                            Console.WriteLine("\nNombre del huesped " + datos.nombre + "\nEdad del huesped " + datos.edad + "\nNumero telefonico " + datos.telefono + "\nDomicilio de origen" + datos.domicilio + "\nDocumento de identificacion " + datos.tipIdentificacion);

                            Console.WriteLine("**********************Servicios adicionales*******************************");
                            Console.WriteLine(extras.NomServicio);
                            Console.WriteLine("**************Datos de la reservacion**************");
                            simple.fecha = DateTime.Today;
                            Console.WriteLine("Folio " + simple.id + "\nTipo de habitacion " + simple.nomHabitacion + "\nDias a hospedarse " + simple.dias + "\nFecha de registro " + (simple.fecha = DateTime.Today));
                            Console.WriteLine("Subtotal " + simple.GetCosto());
                            Console.WriteLine("Descuento " + simple.GetDescuento());
                            costoFinal = simple.GetCosto() - simple.GetDescuento();
                            Console.WriteLine("Costo total " + costoFinal);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("**********************Datos del cliente*******************************");
                            Console.WriteLine("\nNombre del huesped " + datos.nombre + "\nEdad del huesped " + datos.edad + "\nNumero telefonico " + datos.telefono + "\nDomicilio de origen" + datos.domicilio + "\nDocumento de identificacion " + datos.tipIdentificacion);
                            
                            Console.WriteLine("**************Datos de la reservacion**************");
                            simple.fecha = DateTime.Today;
                            Console.WriteLine("Folio " + simple.id + "\nTipo de habitacion " + simple.nomHabitacion + "\nDias a hospedarse " + simple.dias + "\nFecha de registro " + (simple.fecha = DateTime.Today));
                            Console.WriteLine("Subtotal " + simple.GetCosto());
                            Console.WriteLine("Descuento " + simple.GetDescuento());
                            costoFinal = simple.GetCosto() - simple.GetDescuento();
                            Console.WriteLine("Costo total " + costoFinal);
                            Console.ReadKey();
                            Console.Clear();
                        }
                       

                        break;
                    case 2:
                        standar.nomHabitacion = "Suite Standar";
                        datos.Huesped();

                        Console.WriteLine("Cuantos dias desea hospedarse?");
                        standar.dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el dia de registro");
                        standar.dia = Console.ReadLine();

                        Console.WriteLine("Desea algun servicio extra?");
                        servicios = Console.ReadLine();
                        if (servicios == "Si" || servicios == "si")
                        {
                            extras.NomServicio = "";
                            extras.GetServicios();
                            Console.WriteLine("**********************Datos del cliente*******************************");
                            Console.WriteLine("\nNombre del huesped " + datos.nombre + "\nEdad del huesped " + datos.edad + "\nNumero telefonico " + datos.telefono + "\nDomicilio de origen" + datos.domicilio + "\nDocumento de identificacion " + datos.tipIdentificacion);

                            Console.WriteLine("**********************Servicios adicionales*******************************");
                            Console.WriteLine(extras.NomServicio);
                            Console.WriteLine("**************Datos de la reservacion**************");
                            simple.fecha = DateTime.Today;
                            Console.WriteLine("Folio " + standar.id + "\nTipo de habitacion " + standar.nomHabitacion + "\nDias a hospedarse " + standar.dias + "\nFecha de registro " + (standar.fecha = DateTime.Today));
                            Console.WriteLine("Subtotal " + standar.GetCosto());
                            Console.WriteLine("Descuento " + standar.GetDescuento());
                            costoFinal = standar.GetCosto() - standar.GetDescuento();
                            Console.WriteLine("Costo total " + costoFinal);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("**********************Datos del cliente*******************************");
                            Console.WriteLine("\nNombre del huesped " + datos.nombre + "\nEdad del huesped " + datos.edad + "\nNumero telefonico " + datos.telefono + "\nDomicilio de origen" + datos.domicilio + "\nDocumento de identificacion " + datos.tipIdentificacion);

                            Console.WriteLine("**************Datos de la reservacion**************");
                            simple.fecha = DateTime.Today;
                            Console.WriteLine("Folio " + standar.id + "\nTipo de habitacion " + standar.nomHabitacion + "\nDias a hospedarse " + standar.dias + "\nFecha de registro " + (standar.fecha = DateTime.Today));
                            Console.WriteLine("Subtotal " + standar.GetCosto());
                            Console.WriteLine("Descuento " + standar.GetDescuento());
                            costoFinal = standar.GetCosto() - standar.GetDescuento();
                            Console.WriteLine("Costo total " + costoFinal);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        ejectuvia.nomHabitacion = "Suite Ejecutiva";
                        datos.Huesped();

                        Console.WriteLine("Cuantos dias desea hospedarse?");
                        ejectuvia.dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el dia de registro");
                        ejectuvia.dia = Console.ReadLine();

                        Console.WriteLine("Desea algun servicio extra?");
                        servicios = Console.ReadLine();
                        if (servicios == "Si" || servicios == "si")
                        {
                            extras.NomServicio = "";
                            extras.GetServicios();
                            Console.WriteLine("**********************Datos del cliente*******************************");
                            Console.WriteLine("\nNombre del huesped " + datos.nombre + "\nEdad del huesped " + datos.edad + "\nNumero telefonico " + datos.telefono + "\nDomicilio de origen" + datos.domicilio + "\nDocumento de identificacion " + datos.tipIdentificacion);

                            Console.WriteLine("**********************Servicios adicionales*******************************");
                            Console.WriteLine(extras.NomServicio);
                            Console.WriteLine("**************Datos de la reservacion**************");
                            ejectuvia.fecha = DateTime.Today;
                            Console.WriteLine("Folio " + ejectuvia.id + "\nTipo de habitacion " + ejectuvia.nomHabitacion + "\nDias a hospedarse " + ejectuvia.dias + "\nFecha de registro " + (ejectuvia.fecha = DateTime.Today));
                            Console.WriteLine("Subtotal " + ejectuvia.GetCosto());
                            Console.WriteLine("Descuento " + ejectuvia.GetDescuento());
                            Console.WriteLine("Servicio " + extras.costoTotal);
                            costoFinal = (ejectuvia.GetCosto() - ejectuvia.GetDescuento())+extras.costoTotal;
                            Console.WriteLine("Costo total " + costoFinal);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("**********************Datos del cliente*******************************");
                            Console.WriteLine("\nNombre del huesped " + datos.nombre + "\nEdad del huesped " + datos.edad + "\nNumero telefonico " + datos.telefono + "\nDomicilio de origen" + datos.domicilio + "\nDocumento de identificacion " + datos.tipIdentificacion);

                            Console.WriteLine("**************Datos de la reservacion**************");
                            ejectuvia.fecha = DateTime.Today;
                            Console.WriteLine("Folio " + ejectuvia.id + "\nTipo de habitacion " + ejectuvia.nomHabitacion + "\nDias a hospedarse " + ejectuvia.dias + "\nFecha de registro " + (ejectuvia.fecha = DateTime.Today));
                            Console.WriteLine("Subtotal " + ejectuvia.GetCosto());
                            Console.WriteLine("Descuento " + ejectuvia.GetDescuento());
                            costoFinal = ejectuvia.GetCosto() - ejectuvia.GetDescuento();
                            Console.WriteLine("Costo total " + costoFinal);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        Console.Clear();
                        i--;
                        Console.SetCursorPosition(32, 1); Console.WriteLine("Habitacion simple");
                        Console.WriteLine(simple.Informacion());
                        Console.SetCursorPosition(32, 10); Console.WriteLine("Habitacion Suite Standar");
                        Console.WriteLine(standar.Informacion());
                        Console.SetCursorPosition(32, 18); Console.WriteLine("Habitacion Suite Ejecutiva");
                        Console.WriteLine(ejectuvia.Informacion());
                        Console.ReadKey();

                        break;

                    default:
                        Console.Clear();
                        i--;
                        Console.WriteLine("Error opcion no valida");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }





            Console.WriteLine("Hoda");
        

    
        }
    }

}
