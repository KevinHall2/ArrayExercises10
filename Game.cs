using System;
using System.Diagnostics;
using System.Numerics;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises10
{
    internal class Game
    {
        public void Run()
        {
            int[] ints = GetValues();

            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);
        }
        //declaring the array that will be used by all functions 
        int[] theArray = new int[5];
        int[] GetValues()
        {
            //declaring variable that will be used to increment the while loop and determine which index is being inputted
            int incrementor = 0;
            while (incrementor < theArray.Length)
            {
                if (incrementor == 0)
                {
                    string input1 = "";
                    int index1 = 0;
                    Console.WriteLine("Input the first index value.");
                    Console.Write(">");
                    input1 = Console.ReadLine();
                    if (Int32.TryParse(input1, out int num))
                    {
                        index1 = num;
                    }
                    theArray[0] = index1;
                }
                else if (incrementor == 1)
                {
                    string input2 = "";
                    int index2 = 0;
                    Console.WriteLine("Input the second index value.");
                    Console.Write(">");
                    input2 = Console.ReadLine();
                    if (Int32.TryParse(input2, out int num))
                    {
                        index2 = num;
                    }
                    theArray[1] = index2;
                }
                else if (incrementor == 2)
                {
                    string input3 = "";
                    int index3 = 0;
                    Console.WriteLine("Input the third index value.");
                    Console.Write(">");
                    input3 = Console.ReadLine();
                    if (Int32.TryParse(input3, out int num))
                    {
                        index3 = num;
                    }
                    theArray[2] = index3;
                }
                else if (incrementor == 3)
                {
                    string input4 = "";
                    int index4 = 0;
                    Console.WriteLine("Input the fourth index value.");
                    Console.Write(">");
                    input4 = Console.ReadLine();
                    if (Int32.TryParse(input4, out int num))
                    {
                        index4 = num;
                    }
                    theArray[3] = index4;
                }
                else if (incrementor == 4)
                {
                    string input5 = "";
                    int index5 = 0;
                    Console.WriteLine("Input the fifth index value.");
                    Console.Write(">");
                    input5 = Console.ReadLine();
                    if (Int32.TryParse(input5, out int num))
                    {
                        index5 = num;
                    }
                    theArray[4] = index5;
                }


                incrementor++;
            }
            return null;
        }

        int[] PrintArray(int[] array)
        {
            Console.WriteLine("The indexes of the array are: ");
            foreach (int num in theArray)
            {               
                Console.WriteLine("-----------");
                Console.WriteLine(num);
            }
            return null;
        }

        int PrintSum(int[] array)
        {
            //decalring int variable to print out at the end of calculations
            int arraySum = 0;

            foreach (int num in theArray)
            {
                arraySum += num;
            }

            Console.WriteLine("");
            Console.WriteLine("The sum of the indexes is: " + arraySum);

            return 0;
        }

        int PrintHighest(int[] array)
        {
            return 0;
        }

        int PrintLowest(int[] array)
        {
            return 0;
        }

        int[] PrintReverse(int[] array)
        {
            Console.WriteLine("The indexes of the array in the reverse order are: ");
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(theArray[i]);
            }
            return null;
        }
    }
    
}
