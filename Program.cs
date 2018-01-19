using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathchallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, digitsno; int[] array1; int[] array2;

            Console.WriteLine("enter the first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of digits of number1");
            digitsno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the srcond number with the same number of digits as the first number");
            number2 = int.Parse(Console.ReadLine());

            array1 = converttoarray(number1, digitsno);
            array2 = converttoarray(number2, digitsno);
            int []array3 =addarrays ( a1: array1, b1:array2, digit: digitsno);

            Console.WriteLine(equalornot(array3));
            Console.ReadKey();


            bool equalornot(int []ar)
            {
                bool flag;
               for(int j=0; j< digitsno; j++)
                {
                    if (ar[j]!=ar[j+1])
                    {
                        return (false);
                        
                    }
                    

                }
                flag = true;
                return (flag);
            }


            int[] converttoarray(int num, int length)
            {
                int value;

                int[] digits = new int[length];
                for (int index = length - 1; index >= 0; index--)
                {
                    digits[index] = num % 10;
                    value = num / 10;
                }

                return digits;

            }



             int[] addarrays(int[] a1, int[] b1, int digit)
            {

                int[] c1 = new int[digit];

                for (int i = 0; i < digit; i++)
                {

                    c1[i] = a1[i] + b1[i];
                }
                return (c1);
            }

        }

       
    }
}

