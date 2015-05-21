using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace HybridEncryption
{
    public static class SecureStringExt
    {
        public static byte[] Unprotect(this SecureString secret)
        {
            var ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.SecureStringToBSTR(secret);
                var content = new char[secret.Length];
                Marshal.Copy(ptr, content, 0, secret.Length);
                
                return Encoding.UTF8.GetBytes(content);
            }
            finally
            {
                if (ptr != IntPtr.Zero) Marshal.ZeroFreeBSTR(ptr);
            }
        }
    }
}