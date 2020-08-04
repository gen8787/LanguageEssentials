using System;
using System.Collections.Generic;

// Create an empty List of type object
// Add the following values to the list: 7, 28, -1, true, "chair"
// Loop through the list and print all values (Hint: Type Inference might help here!)
// Add all values that are Int type together and output the sum

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");
            int sum = 0;

            foreach (object obj in list)
            {
                Console.WriteLine(obj);

                if (obj is int)
                {
                    // Console.WriteLine(obj + " is an integer.");
                    sum +=  ((int)obj);
                    Console.WriteLine(sum);
                }
                if (obj is string)
                {
                    // Console.WriteLine(obj + " is a string.");
                }
            }
            
        }
    }
}