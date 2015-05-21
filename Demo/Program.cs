using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using HybridEncryption;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Password: ");
            var password = SecureConsole.ReadLine("*"); // Cosider to omit this '*' mask char, because it leaks password length

            Console.WriteLine("Your password is '{0}'", 
                Encoding.UTF8.GetString(password.Unprotect())
                );
        }
    }
}
