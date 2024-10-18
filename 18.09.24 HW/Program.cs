using System;
using System.Collections.Generic;

namespace Interface2
{
    // Task 1
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    // Task 2
    interface IShow
    {
        void ShowEven();
        void ShowOdd();
    }

    // Task 3
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    class Aray : ICalc, IShow, ICalc2
    {
        public int[] arr { get; set; }

        public Aray(int[] arr)
        {
            this.arr = arr;
        }

        //Task 1
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        //Task 2
        public void ShowEven()
        {
            Console.WriteLine("Even elements:");
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd elements:");
            foreach (var i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Task 3
        public int CountDistinct()
        {
            HashSet<int> uniqueElements = new HashSet<int>(arr);
            return uniqueElements.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (valueToCompare == item)
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Aray obj = new Aray(new[] { 2, 3, 4, 5, 6, 7, 8, 9 });

            //Task 1
            Console.WriteLine("Number of elements greater than 5: " + obj.Greater(5));
            Console.WriteLine("Number of elements less than 6: " + obj.Less(6));

            //Task 2
            obj.ShowEven();
            obj.ShowOdd();

            //Task 3
            Console.WriteLine("Number of distinct elements: " + obj.CountDistinct());
            Console.WriteLine("Number of elements equal to 4: " + obj.EqualToValue(4));
        }
    }
}