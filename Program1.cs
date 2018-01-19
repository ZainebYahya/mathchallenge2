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
            //ask the user to enter the first number//
            Console.WriteLine("enter the first number");

            //convert the string to integer and stor it in number1//
            number1 = int.Parse(Console.ReadLine());

            //ask the user about the number of the digits//
            Console.WriteLine("enter the number of digits of number1");

            //convert the string to integer and stor it in digitsno//
            digitsno = int.Parse(Console.ReadLine());

            //ask the user to enter the second number//
            Console.WriteLine("enter the srcond number with the same number of digits as the first number");

            //convert the string to integer and stor it in number2//                  
            number2 = int.Parse(Console.ReadLine());


            //convert both numbers to two arrays of digits by using the function(converttoarray) //
            array1 = converttoarray(number1, digitsno);
            array2 = converttoarray(number2, digitsno);


            //add both arrays by using the function(addarrays) and return one new array//
            int []array3 =addarrays ( a1: array1, b1:array2, digit: digitsno);



            //use the function equalornot to print the result//
            Console.WriteLine(equalornot(ar:array3,dig:digitsno));
            Console.ReadKey();


            /* in this functionwill send the  array and digits number will compare between the value of the element in the array so if they're all equal 
            the function will return true else will return false*/
            bool equalornot(int[] ar,int dig)
            {
                bool flag;
                for (int j = 0; dig > 0; dig--, j++)
                {
                    if (ar[j] == ar[j + 1])
                    {

                        flag = true;
                        return (flag);

                    }
                    else flag = false;
                    return (flag);


                }
                flag = false;
                return (flag);
            }




            /*in this function will send number and its digit  and return array will convert number to array of digits will use (/ and %)  by using % will take the ones 
             and put in array and then will use / to get rid of the ones that we saved and wii keep diong that until
             the numer =0  so we saved all the digits of the number in the array*/
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


            /*in this function will add the two arrays will send two arrays with the digit no. and wii return one
             array */
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

