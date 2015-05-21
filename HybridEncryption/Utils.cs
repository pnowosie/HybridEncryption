using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace HybridEncryption
{
    public static class BytesUtils
    {
        public static bool Compare(byte[] original, byte[] other)
        {
            if (other == null) return false;
            var result = original.Length == other.Length;

            // other is potencialy malicious, don't want to leak original.Length
            for (int i = 0; i < other.Length; ++i)
            {
                byte originalByte = (i < original.Length) ? original[i] : (byte)0;
                result &= originalByte == other[i];
            }

            return result;
        }
    }

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