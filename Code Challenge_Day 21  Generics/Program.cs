using System;

namespace Code_Challenge_Day_21__Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for(int i=0;i<n;i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for(int j=0;j<n;j++)
            {
                stringArray[j] = Console.ReadLine();
            }

            PrintArray<Int32>(intArray);
            PrintArray<string>(stringArray);

            
        }

        private static void PrintArray<T>(T[] Array)
        {
            Console.WriteLine();

            foreach(T item in Array)
            {               
                Console.WriteLine(item);
            }
        }
    }
}
