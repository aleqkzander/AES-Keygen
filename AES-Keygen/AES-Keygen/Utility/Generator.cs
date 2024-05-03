using System.Security.Cryptography;

namespace AES_Keygen.Utility
{
    internal class Generator
    {
        public static string GenerateRandomKey()
        {
            using Aes aes = Aes.Create();
            aes.KeySize = 256;
            aes.GenerateKey();
            string keyString = BitConverter.ToString(aes.Key).Replace("-", "");
            return keyString;
        }
    }
}