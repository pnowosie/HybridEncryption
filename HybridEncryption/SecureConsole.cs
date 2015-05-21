using System;
using System.Security;

namespace HybridEncryption
{
    public static class SecureConsole
    {
        public static SecureString ReadLine(string mask = null)
        {
            var result = new SecureString();
            
            var input = Console.ReadKey(true);
            while (input.Key != ConsoleKey.Enter)
            {
                Console.Write(mask);    // write a feedback to the user
                result.AppendChar(input.KeyChar);
                input = Console.ReadKey(true);
            }
            Console.WriteLine();    // echo the ENTER key back

            return result;
        }
    }
}