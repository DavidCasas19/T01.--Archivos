using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class login
    {
        public void IngresarDatos()
        {

            Console.WriteLine("Ingresa tu nombre de Usuario:");
            string user = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña: ");
            string pass = Console.ReadLine();

            Usuario U = new Usuario();
            U.Username = user;
            U.Password = pass;
            Registro R = new Registro();
            string ruta = "Datos.txt";
            List<string> datos = R.ObtenerLineas(ruta);

           ValidarDatos(U, datos);
        }

        public void ValidarDatos(Usuario u, List<string> datos)
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach(var item in datos)
            {
                string[] info = item.Split(',');
                usuarios.Add(new Usuario { Nombre = info[0], Username = info[1], Password = info[2] });

            }
            foreach(var us in usuarios)
            {
                if (u.Username == us.Username && u.Password == us.Password)
                {
                    Bienvenida();
                    Console.ReadKey();
                }


            }
        }

        private void Bienvenida()
        {
            Console.WriteLine("Bienvenido");
            Console.ReadKey();
        }
    }
}
