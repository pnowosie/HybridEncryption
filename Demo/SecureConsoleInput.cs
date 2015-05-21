using System;
using System.Text;
using HybridEncryption;

namespace Demo
{
    partial class Program
    {
        public static void SecureConsoleInputDemo()
        {
            // Common secnario when user is asked to input a password and then to confirm it
            Console.Write("Password: ");
            var password = SecureConsole.ReadLine("*"); // Cosider to omit this '*' mask char, because it leaks password length

            Console.Write("Confirm: ");
            var confirmPwd = SecureConsole.ReadLine(); // no mask character is echoed this time

            // Compare passwords using constant-time comparison method
            var passwordMatch = BytesUtils.Compare(
                password.Unprotect(), 
                confirmPwd.Unprotect()
            );

            Console.WriteLine("Password {0}!", passwordMatch ? "accepted" : "does't match");
            if (passwordMatch)
            {
                Console.WriteLine("And by the way, your password is '{0}' :-P",
                    Encoding.UTF8.GetString(password.Unprotect())
                    );
            }
        }
    }
}