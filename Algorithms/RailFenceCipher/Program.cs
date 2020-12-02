using System;

namespace RailFenceCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var encryptedString = Cipher.Encrypt("MishaKarpa", 4);
            Console.WriteLine(encryptedString);
            Console.Write(Cipher.Decrypt(encryptedString, 4));
        }
    }
}
