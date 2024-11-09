using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_the_Smallest_Number_in_an_Array
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finding the Smallest Number in an Array";


            int[] firstArray = { -125, -21, 420, 5, 602, 7, -238, 9, 150, 11, 12, 13, 184, -15, -146, 17, -418, 19, 20, 21, 22, 23, 24, 25, 26, 227, -28, 29, 30, 341, 392, };

            int currentSmallest = int.MaxValue;

            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] < currentSmallest)
                    currentSmallest = firstArray[index];



            }

            Console.WriteLine(currentSmallest);
            Console.Read(); 
        }



    }




}
        
