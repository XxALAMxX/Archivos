using System;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string arc, arc2;
            Funciones funcion = new Funciones(); 
            
            Console.WriteLine("Dame el nombre de un archivo: ");
            arc = Console.ReadLine();
            funcion.Existe_Archivo(arc);
            Console.WriteLine("Dame el nombre de otro archivo: ");
            arc2 = Console.ReadLine();
            funcion.Existe_Archivo(arc2);
            Archivo archivo = new Archivo(arc);
            Archivo archivo2 = new Archivo(arc2);
            archivo.leer();
            archivo2.leer();         
        }
    }
}
