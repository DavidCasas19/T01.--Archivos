using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autenticacion
{
    class Program
    {

        static void Main(string[] args)
        {
            Registro r = new Registro();
            Usuario us = new Usuario();
            login log = new login();
            Console.WriteLine("Elige un numero de la accion deseada");
            Console.WriteLine("1.-iniciar sesion");
            Console.WriteLine("2.-Registrarse");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                log.IngresarDatos();
            }
            else if (n == 2)
            {
                r.RegistrarUsuario(us,"Datos.txt");
            }
        }

        //private static void Menu()
        //{

        //  login Log = new login();

        //Console.WriteLine("1.- Registrarse");
        //switch (Console.ReadLine())
        // {
        //  case "1":
        //   Log.IngresarDatos();

        //break;
        //case "2":
        // Log.ValidarDatos();
        //break;


        // }



    }
    //   private static void Registrese()
    // {

    //   string path = "Datos.txt";

    // Registro reg = new Registro();

    //reg.RegistrarUsuario(us, path);
    //}
}

