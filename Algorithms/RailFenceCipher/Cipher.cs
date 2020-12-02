using System;
using System.Collections.Generic;
using System.Text;

namespace RailFenceCipher
{
    public class Cipher
    {
        public static string Encrypt(string str, int key)
        {
            string[,] railFence = new string[key, str.Length];

            bool direction = false;
            int row = 0, column = 0, lowerIndex = key - 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (row == 0 || row == lowerIndex)
                    direction = !direction;

                railFence[row, column++] = str[i].ToString();

                if (direction)
                    row++;
                else
                    row--;
            }

            string result = "";
            for (int i = 0; i < key; i++)
                for (int j = 0; j < str.Length; j++)
                    result += railFence[i, j];
            return result.Replace(" ", "");
        }

        public static string Decrypt(string cipher, int key)
        {
            string[,] rail = new string[key, cipher.Length];
            
            for (int i = 0; i < key; i++)
                for (int j = 0; j < cipher.Length; j++)
                    rail[i, j] = " ";

            bool down = false;

            int row = 0, col = 0;

            for (int i = 0; i < cipher.Length; i++)
            {
                if (row == 0)
                    down = true;
                if (row == key - 1)
                    down = false;

                rail[row, col++] = "*";

                if (down)
                    row++;
                else
                    row--;
            }

            int index = 0;
            for (int i = 0; i < key; i++)
                for (int j = 0; j < cipher.Length; j++)
                    if (rail[i, j].Equals("*") && index < cipher.Length)
                        rail[i, j] = cipher[index++].ToString();
            
            string result = "";

            row = 0; col = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                if (row == 0)
                    down = true;
                if (row == key - 1)
                    down = false;

                if (!rail[row, col].Equals("*"))
                    result += rail[row, col++];

                if (down)
                    row++;
                else
                    row--;
            }
            return result.Replace(" ", "");
        }
    }
}
