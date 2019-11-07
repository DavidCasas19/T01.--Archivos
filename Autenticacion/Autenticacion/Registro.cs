using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autenticacion
{
    public class Registro
    {
       
        public void RegistrarUsuario(Usuario U,string path)
        {
            
            Console.WriteLine("Nombre completo");
            U.Nombre = Console.ReadLine();

            Console.WriteLine("Nombre de usuario");
            U.Username = Console.ReadLine();

            Console.WriteLine("Contraseña");
            U.Password = Console.ReadLine();

            string data =U.Nombre + "\n" + U.Username + "\n" + U.Password;

            var datos = ObtenerLineas(path);
            if (datos != null)
            {
                datos.Add(data);
                File.WriteAllLines(path, datos);
            }
            else
            {

                File.WriteAllText(path, data);
            }
        }

        public List<string> ObtenerLineas(string ruta)
        {
            string[] data = null;
            //No existe existe el archivo
            if (File.Exists(ruta))
            {
                data = File.ReadAllLines(ruta);
                
            }
            else
            {
                Console.WriteLine("Archivo no existe");
                return null;
            }

            List<string> datos = new List<string>();

            foreach (var item in data)
            {
                datos.Add(item);
            }
         
            return datos;
        }
    }
    }

