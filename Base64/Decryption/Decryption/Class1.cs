using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decryption
{
    public class fromBase64
    {
        //Konverton nje karakter me numer perkates me baze 64.
        public int convertCharToInt(char character)
        {
            int found = 0;
            string range = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

            for (int i = 0; i < range.Length; i++)
            {
                if (character == range[i])
                {
                    found = i;
                    break;
                }
            }

            return found;
        }

        StringBuilder first = new StringBuilder();
        //Kthen nje numer te vetem ne binar.
        public string ConvertIntToBinary(int numri)
        {
            if (numri == 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    first.Insert(0, 0);
                }

                return first.ToString(); //vec njo mjafton se tjerat i mush paddingu
            }
            if (numri == 1)
            {
                first.Insert(0, 1);

                while (first.Length % 6 != 0)
                {
                    first.Insert(0, 0);
                }

                return first.ToString();
            }
            if (numri % 2 == 0)
            {
                first.Insert(0, 0);
            }
            if (numri % 2 == 1)
            {
                first.Insert(0, 1);
            }

            numri = numri / 2;
            ConvertIntToBinary(numri);

            return first.ToString();
        }

        StringBuilder second = new StringBuilder();
        //Kthen nje tekst ne numra binar 6 bitesh.
        public string convertTextToBinary(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                first.Clear();
                int charPerText = convertCharToInt(text[i]);
                second.Append(ConvertIntToBinary(charPerText));
            }

            return second.ToString();
        }

        StringBuilder third = new StringBuilder();
        //Teksti i marrur nga funksioni convertTextToBinary
        public string splitByEightBits(string text)
        {
            double sum = 0;
            char pos = '1';

            if (text.Length % 8 != 0)
            {
                text = text.PadRight(text.Length + (8 - text.Length % 8), '0');
            }

            for (int i = 0; i < text.Length; i = i + 8)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (text[i+j].Equals(pos))
                    {
                        sum = sum + Math.Pow(2, (7 - j));
                    }
                    else
                    {
                        sum = sum + 0;
                    }
                    
                }

                sum = Math.Floor(sum);
                int fin = Convert.ToInt32(sum);
                third.Append((char)fin);
                sum = 0;
            }

            return third.ToString();
        }
        //Metoda finale qe kombinon metodat e mesiperme.
        public string Decode (string text)
        {
            text = text.Replace("=", "");
            string string1 = convertTextToBinary(text);
            string string2 = splitByEightBits(string1);

            first.Clear();
            second.Clear();
            third.Clear();

            return string2;
        }
        //Kontrollon a eshte valid teksti per dekriptim.

        public bool isStringValid (string text)
        {
            string range = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";

            for (int i = 0; i < text.Length; i++)
            {
                if (!range.Contains(text[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}