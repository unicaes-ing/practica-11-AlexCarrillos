using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Carrillos Gaitan 11/11/19
namespace GUIA111
{
//    Elaborar un programa para almacenar en un archivo binario, los siguientes datos del cliente: nombre,
//teléfono, fecha de nacimiento y salario(si el archivo existe será sobrescrito)
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*****INGRESAR DATOS DEL CLIENTE*****");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nombre de el cliente:");
                string Nombrecliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Numero telefonico de el cliente:");
                string Telecliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento de el cliente:");
                string FeNcliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Salario de el cliente:");
                decimal Salariocliente = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("Datos_clien.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(Nombrecliente);
                binario.Write(Telecliente);
                binario.Write(FeNcliente);
                binario.Write(Salariocliente);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Los datos se almacenaron correctamente...");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ocurrio un error al guardar los datos del cliente...");
            }
        }
    }
}
