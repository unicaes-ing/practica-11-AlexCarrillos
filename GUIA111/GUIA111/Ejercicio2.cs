using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Carrillos Gaitan 11/11/19

namespace GUIA111
{
    class Ejercicio2
    {
//        Elaborar un programa para leer los datos del cliente almacenados en el archivo binario y mostrarlosen pantalla.
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("Datos_clien.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string Nombrecliente = binario.ReadString();
                string Telecliente = binario.ReadString();
                string FeNcliente = binario.ReadString();
                decimal Salariocliente = binario.ReadDecimal();
                stream.Close();
                binario.Close();
                Console.WriteLine("Datos de el cliente...");
                Console.WriteLine();
                Console.WriteLine("Nombre de el cliente: {0}", Nombrecliente);
                Console.WriteLine();
                Console.WriteLine("numero de telefono de el cliente: {0}", Telecliente);
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento de el cliente: {0}", FeNcliente);
                Console.WriteLine();
                Console.WriteLine("Salario de el cliente: {0:C2}", Salariocliente);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presione la tecla <ENTER> para salir");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al guardar los datos del cliente...");
            }
        }
    }
}
 