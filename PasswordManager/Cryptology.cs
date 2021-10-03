using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class Cryptology
    {
        //This is simple Caesar Cipher
        public static string Encryption(string text, int key)
        {
            char[] textChars = text.ToCharArray();
            string encryptedText = null;
            foreach (char item in textChars)
            {
                encryptedText += Convert.ToChar(item+key);
            }
            return encryptedText;
        }

        public static string Decryption(string text, int key)
        {
            char[] textChars = text.ToCharArray();
            string decryptedText = null;

            foreach (char item in textChars)
            {
                decryptedText += Convert.ToChar(item - key);
            }
            return decryptedText;
        }
    }
}
