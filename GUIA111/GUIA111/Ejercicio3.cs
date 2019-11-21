using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Carrillos Gaitan 11/11/19
namespace GUIA111
{
//    Crear un programa para almacenar en un archivo binario: el carnet, nombre, edad y CUM de los
//alumnos, proporcionando un menú con las siguientes opciones.
//1) Agregar alumno
//2) Mostrar alumnos(a) todos los alumnos, b) filtrado por CUM
//3) Buscar alumno
//4) Salir
    class Ejercicio3
    {
        public static void MenuInicial()
        {
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("********INGRESAR DATOS DE ALUMNO******");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("[1] Agregar Alumno");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine("[2] Mostrar Alumnos");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("[3] Buscar Alumno");
            Console.SetCursorPosition(65, 18);
            Console.WriteLine("[4] Salir" +
                "");
            Console.SetCursorPosition(65, 22);
            Console.Write("INGRESA UNA OPCION:  ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Ingresar();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Buscar();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("PRESIONA <ENTER> PARA SALIR");
                    Console.ReadKey();
                    break;

            }
        }
        static void Main(string[] args)
        {
            MenuInicial();
            Console.ReadKey();
        }
        public static void Ingresar()
        {
            try
            {
                Console.WriteLine("INGRESA LOS DATOS CORRESPONDIENTES");
                Console.WriteLine("******************************************************");
                Console.WriteLine();
                Console.WriteLine("Ingresar el carnet de el alumno:");
                string carnetEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresar el nombre de el alumno: ");
                string nombreEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresar la edad de el alumno:");
                int edadEstudiante = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingresar el CUM de el alumno:");
                decimal cumEstudiante = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("DatosCliente.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(carnetEstudiante);
                binario.Write(nombreEstudiante);
                binario.Write(edadEstudiante);
                binario.Write(cumEstudiante);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("LOS DATOS SE ALMACENARON EXITOSAMENTE");
                Console.ReadKey();


            }
            catch (Exception)
            {

                Console.WriteLine("HA OCURRIDO UNERROR AL GUARDAR LOS DATOS");
            }
        }
        public static void Mostrar()
        {
            Console.WriteLine("QUE DESEAS MOSTRAR");
            Console.WriteLine();
            Console.WriteLine("[1]------------TODOS LOS ALUMNOS");
            Console.WriteLine();
            Console.WriteLine("[2]------------FILTRADOS POR EL CUM");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("ELIGE UNA OPCION:  ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    break;
                case 2:
                    break;
            }

        }
        public static void Buscar()
        {

        }
    }
}
