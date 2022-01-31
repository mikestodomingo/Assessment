using System;
using System.Collections.Generic;

namespace Assessment1
{
    class RandomNumbers
    {
        public static void Main(string[] args)
        {
            Random arrayNumber = new Random();
            List<int> arrayrandomNumber = new List<int>(100);

            for (int num = 1; num <= 100; num++)
            {
                arrayrandomNumber.Add(num);
            }

            for (int num = 1; num <= 1; num++)
            {
                int sortedNumbers = arrayNumber.Next(arrayrandomNumber.Count);
                arrayrandomNumber.RemoveAt(sortedNumbers);
                Console.WriteLine("Print sorted array removed number is {0}", sortedNumbers);
            }

            arrayrandomNumber = Shuffle(arrayrandomNumber);
            for (int n = 1; n <= 1; n++)
            {
                int unsortedNumbers = arrayNumber.Next(arrayrandomNumber.Count);
                arrayrandomNumber.RemoveAt(unsortedNumbers); ;
                Console.WriteLine("Print unsorted array removed number is {0}", unsortedNumbers);
            }
            Console.ReadLine();
        }

        public static List<T> Shuffle<T>(List<T> unsortedList)
        {
            Random randomlyNumber = new Random();
            for (int num = 1; num <= 1; num++)
            {
                int numbers = randomlyNumber.Next(1, num);
                T value = unsortedList[numbers];
                unsortedList[num] = value;
            }
            return unsortedList;
        }
    }
}
