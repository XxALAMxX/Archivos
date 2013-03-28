using System;
using System.IO;

namespace Archivos
{
    public class Archivo
    {
        private string path;

        public Archivo(String path)
        {
            this.path = path;
        }

        public void setPath(String path)
        {
            this.path = path;
        }

        public void leer()
        {
            String linea;
            try
            {
                //Se indica el archivo a leer
                StreamReader lector = new StreamReader(this.path);
                StreamWriter escritor = new StreamWriter("Resultado.txt", true);
                //Lee la primera linea del archivo
                Console.WriteLine("Texto en " + this.path);
                
                //Continua leyendo hasta que se termina el archivo
                do{
                    linea = lector.ReadLine();
                    escritor.WriteLine(linea);
                    //Escribe la linea en la consola
                    Console.WriteLine(linea);
                    //Lee la siguiente linea
                } while (linea != null) ;
                lector.Close();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: " + e.Message);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }

        public void escribir(String[] contenido)
        {
            try
            {

                //Se indica el archivo a leer
                StreamWriter escritor = new StreamWriter(this.path, true);

                foreach (String linea in contenido)
                {
                    //Escribe una linea
                    escritor.WriteLine(linea);
                }
                //Cierra escritor
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Cerrando la escritura.");
            }
            
        }
    }
}