using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class usuarios
    {
        public static string [] users = {"Admin","Jose","Ricardo","Carmela"};
        public static string[] password = { "0000", "holaa","25032000","jose" };
        public  string valida(string usuario, string contraseña)
        {
            string mensaje="invalido";

            for (int i = 0; i < users.Length; i++)
            {
                if (usuario == users[i] && contraseña == password[i] )
                {
                    mensaje = "valido";
                }

            }

            return mensaje;
        }
    }
}
