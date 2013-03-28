using System;
using System.IO;

namespace Archivos
{
    class Funciones
    {
        public void Existe_Archivo(string archivo) 
        {
            if (File.Exists(archivo))
                Console.WriteLine("El archivo:" + archivo + " existe");
            else
                Console.WriteLine("El archivo:" + archivo + " no existe");
        }
    }
}
