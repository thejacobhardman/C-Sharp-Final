using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Final
{
    class Program
    {
        public const int SIZE = 10;
        static char[,] someArray = new char[SIZE, SIZE];
        public static void Main(string[] args)
        {
            populateArray();
            printArray();

            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadKey();
        }

        public static void populateArray()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (j % 2 == 0 && i % 2 == 0)
                    {
                        someArray[i, j] = '*';
                    } else if (j % 2 == 1 && i % 2 == 1)
                    {
                        someArray[i, j] = '*';
                    } else
                    {
                        someArray[i, j] = '!';
                    }
                }
            }
        }

        public static void printArray()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write("{0}", someArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
