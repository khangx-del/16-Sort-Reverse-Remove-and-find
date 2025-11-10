using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Sort_Reverse_Remove_and_find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {45,12, 78 ,34 ,89 , 23};

            for (int numbersIndex = 0; numbersIndex < numbers.Length; numbersIndex++)
            {
                Console.WriteLine(numbers[numbersIndex]);
            }
            Console.WriteLine();
            
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine() ;

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine() ;

            Array.Clear(numbers, 1,1); 
           
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            int search = 34;
            int position = Array.IndexOf(numbers, search);
           
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == position)
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                Console.WriteLine($"number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"number {search} doesn't");
            }

            Console.WriteLine();

            int[] newarray = { 45, 12, 78, 89, 23 };

            int searcha = 34;
            int positioni = Array.IndexOf(newarray, searcha);

            for (int i = 0; i < newarray.Length; i++)
            {
                if (newarray[i] == positioni)
                {
                    positioni = i;
                }
            }

            if (positioni > -1)
            {
                Console.WriteLine($"number {searcha} has been found at position {positioni + 1}");
            }
            else
            {
                Console.WriteLine($"number {searcha} doesn't exist");
            }

        }
    }
}
