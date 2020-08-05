using System;
using System.Linq;

namespace Basic13
{
    class Program
    {
// #1 Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (var i = 1; i < 256; i ++)
            {
                Console.WriteLine(i);
            }
        }
// 
// #2 Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (var i = 1; i < 256; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
// 
// #3 Print Sum
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (var i = 0; i < 256; i ++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} --- New sum: {sum}");
            }
        }
// 
// #4 Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console.
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
// 
// #5 Find Max
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach ( int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
            return max;
        }
// 
// #6 Get Average
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach (var num in numbers)
            {
                sum = sum + num;
            }
            int avg = sum / numbers.Length;
            Console.WriteLine("The average is: " + avg);
        }
// 
// #7 Array with Odd Numbers
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] arrOdds = new int[128];
            int oddNum = 1;

            for (int i = 0; i < arrOdds.Length; i ++)
            {
                arrOdds[i] = oddNum;
                oddNum += 2;
            }
            Console.WriteLine("[{0}]", string.Join(", ", arrOdds));
            return arrOdds;

        }
// 
// #8 Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            
            for (int i = 0; i < numbers.Length; i ++)
            {
                if (numbers[i] > y)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
            return count;
        }
// 
// #9 Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i ++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
// 
// #10 Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
// 
// #11 Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int min = numbers[0];
            int max = numbers[0];
            double avg = numbers.Average();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Avg = " + avg);
        }
// 
// #12 Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1)
                {
                    numbers[i] = numbers[i+1];
                }
                else
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
// 
// #13 Number to String
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] objArr = new object[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    objArr[i] = "Dojo";
                }
                else{
                    objArr[i] = numbers[i];
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", objArr));
            return objArr;
        }

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            // PrintNumbers();
            
            // PrintOdds();
            
            // PrintSum();
            
            // int[] numbers = {1, 3, 5, 7, 9};
            // LoopArray(numbers);

            // int[] numbers = {-1, -3, 5, -7, -9};
            // FindMax(numbers);

            // int[] numbers = {2, 10, 3};
            // GetAverage(numbers);

            // OddArray();

            // int[] numbers = {1, 3, 5, 7, 9};
            // int y = 5;
            // GreaterThanY(numbers, y);

            // int[] numbers = {1, 5, 10, -10};
            // SquareArrayValues(numbers);

            // int[] numbers = {-3, 5, 7, 9, -11, 3, -6, 7};
            // EliminateNegatives(numbers);

            // int[] numbers = {1, 5, 15, -2};
            // MinMaxAverage(numbers);

            // int[] numbers = {1, 5, 10, 7, -2};
            // ShiftValues(numbers);

            int[] numbers = {-1, -3, 2};
            NumToString(numbers);


        }
    }
}