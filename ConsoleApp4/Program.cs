using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
//2
            /*Console.WriteLine("Будь ласка, введіть 4-ох значне  число:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine($"{number} є паліндромом.");
                }
                else
                {
                    Console.WriteLine($"{number} не є паліндромом.");
                }*/
        //1
                //DrawSquare(7, '@');
                //Console.WriteLine();
                //DrawRectangle(4, 10, '+');
            }

        /*public static void DrawSquare(int sLength, char symbol)
        {
            if (sLength <= 0)
            {
                Console.WriteLine("Довжина сторони повинна бути додатним цілим числом.");
                return;
            }

            for (int i = 0; i < sLength; i++)
            {
                for (int j = 0; j < sLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void DrawRectangle(int height, int width, char symbol)
        {
            if (height <= 0 || width <= 0)
            {
                Console.WriteLine("Висота та ширина повинні бути додатними цілими числами.");
                return;
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }*/


        
            
       //2     
        /*    else
            {
                Console.WriteLine("Введено некоректне число.");
            }
        }

        public static bool IsPalindrome(int number)
        {
            if (number < 0)
            {
                return false;
            }

            if (number < 10)
            {
                return true;
            }

            string numberString = number.ToString();
            int left = 0;
            int right = numberString.Length - 1;

            while (left < right)
            {
                if (numberString[left] != numberString[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }*/
    }
}
    
