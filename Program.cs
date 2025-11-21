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
            numbers = numbers.Where(n => n != 78).ToArray();
            Console.WriteLine("\nRemove element 78 from array: ");
            foreach (int numRemove in numbers)
            {
            Console.WriteLine(numRemove);
            }
            
        }
    }
}
