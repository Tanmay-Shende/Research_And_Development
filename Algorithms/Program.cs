using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 50,6, 1, 30, 8 };

            //printArray(BubbleSort(age));
            //printArray(QuickSort(age, 0, age.Length - 1));
            //FindSmallStringinBig("abc", "aabcbdgdwegabcadabcad");

            //PrintLetterX();

            //WellFormedString("  Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    ");
            WellFormedSpaces("  Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    Mr      Tanmay     Shende    ");


        }

        static void WellFormedString(string input)
        {
            
            Console.WriteLine("BEFORE : " + input);

            input = input.Trim();
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }

            Console.WriteLine("AFTER  : " + input);

            Console.ReadLine();

        }

        static void WellFormedSpaces(string input)
        {

            Console.WriteLine("BEFORE : " + input);
            Regex trimmer = new Regex(@"\s\s+");

            input = trimmer.Replace(input, " ");

            Console.WriteLine("AFTER  : " + input);

            Console.ReadLine();

        }


        static void PrintLetterX()
        {


            Console.WriteLine("Enter The Size");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The letter");
            char letter = Convert.ToChar(Console.ReadLine());


            if (size % 2 == 0)
                size = size - 1;

            int startIndex;
            int lastIndex;

            for (startIndex=0,lastIndex=size-1; startIndex < size; startIndex++, lastIndex--)
            {
                char[] LineArray = new char[size];
                LineArray[startIndex] = letter;
                LineArray[lastIndex] = letter;

                PrintLineArray(LineArray);


            }

            Console.ReadLine();


        }

        static void PrintLineArray(char[] array)
        {
            if (array == null)
                Console.WriteLine("Array is Empty");

            for (int ctr = 0; ctr < array.Length; ctr++)
            {
                char letter = array[ctr];
                Console.Write(letter);

            }
            Console.WriteLine();
        }

        static int[] FindSmallStringinBig(string smallString, string bigString)
        {
            int[] positions = null;
            for (int bs = 0; bs <=bigString.Length-1; bs++)
            {
                if (bs > bigString.Length - smallString.Length)
                {
                    Console.WriteLine("End of Array - " + bigString[bs]);
                    break;
                }
                
                int bsProxy = 0;
                for (int ss=0; ss<smallString.Length-1; ss++)
                {
                    
                    if (bigString[bs + bsProxy] == smallString[ss])
                    {
                        bsProxy++;
                    }
                    else
                    {
                        break;
                    }
                    if (ss == smallString.Length-1)
                    {
                        Console.WriteLine(bs.ToString());
                    }
                }

                
            }
            Console.ReadLine();
            return positions;
        
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        static int[] QuickSort(int[] array, int left, int right)
        {

            if (left < right)
            {
                int pi = Partition(array, left,right);

                QuickSort(array, left, pi-1);
                QuickSort(array, pi, right);

            }

            return array;

        }

        static public int Partition(int[] array, int left, int right)
        {
            int pivot = right;
            int index = left;
            int current = left;

            for (current = left; current<right; current++)
            {
                if (array[current] < array[pivot])
                {
                    Swap(array, index, current);
                    index++;
                }
            }

            Swap(array, index, pivot);

            return right;
            
        }

        public static void Swap(int[] A, int left, int right)
        {
            int tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }

        static void printArray(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + " " );

            }
            Console.ReadLine();

        }
    }
}
