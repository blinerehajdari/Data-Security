using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class toBase64

    {
        //Gjen karakterin perkates per numrin me baze 64, indeksi i te cilit eshte numer.
        public char convertIntToChar(int number) 
        {										 						
            char found = 'a'; 
            string range = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

            for (int i = 0; i < range.Length; i++)
            {
                if (number == i)
                {
                    found = range[i];
                    break;
                }
            }

            return found;
        }

        StringBuilder first = new StringBuilder(); 
        //Kthen nje numer te vetem binar.
        public string convertIntToBinary(int number)	 
        {								
            if (number == 1) 		
            {						
                first.Insert(0, 1);	
									
                while (first.Length % 8 != 0)  
                {							
                    first.Insert(0, 0);		
                }

                return first.ToString(); 
            }
            if (number % 2 == 0)
            {
                first.Insert(0, 0);
            }
            if (number % 2 == 1) 
            {
                first.Insert(0, 1);
            }

            number = number / 2; 
            
            convertIntToBinary(number); 

            return first.ToString(); 
        }

        StringBuilder second = new StringBuilder();
        //Kthen nje numer te vetem ne binar.
        public string convertTextToBinary(string text) 
        {													
            byte[] byteArray = Encoding.ASCII.GetBytes(text); 
			

            for (int i = 0; i < byteArray.Length; i++) 
            {
                first.Clear();
                string binaryNumber = convertIntToBinary(byteArray[i]); 
                second.Append(binaryNumber); 


            }

            return second.ToString(); 
        }

        StringBuilder third = new StringBuilder();
        //Teksti binar i marrur nga funksioni convert TextToBinary.
        public string splitBySixBits(string text) 
        {				
            double sum = 0;
            char pos = '1'; 	

            if (text.Length % 6 != 0)
            {
                text = text.PadRight(text.Length + (6 - text.Length % 6), '0'); 
            }																		


            for (int i = 0; i < text.Length; i = i + 6) 
            {
                for (int j = 0; j < 6; j++)
                {
                    if (text[i + j].Equals(pos))
                        sum = sum + Math.Pow(2, (5 - j));
                    else
                        sum = sum + 0;
                }

                sum = Math.Floor(sum);
                int fin = Convert.ToInt32(sum);
                third.Append(convertIntToChar(fin));  
                sum = 0; 
            }

            return third.ToString(); 
        }
        //Shton barazimet tek teksti nese moduli i 4 nuk eshte zero.
        public string addPaddingToText(string text) 
        {								 
            if (text.Length % 4 != 0)
            {
                text = text.PadRight(text.Length + (4 - text.Length % 4), '='); 
            }																			

            return text;
        }

        //Metoda finale qe kombinon metodat e mesiperme.
        public string Encode(string text)
        {
            string string1 = convertTextToBinary(text); 
            string string2 = splitBySixBits(string1);

            first.Clear(); 
            second.Clear();
            third.Clear();

            return addPaddingToText(string2); 
        }
    }
}