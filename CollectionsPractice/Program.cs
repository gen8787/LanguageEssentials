using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
// Three Basic Arrays
    // Create an array to hold integer values 0 through 9
            int[] arr0To9 = {1,2,3,4,5,6,7,8,9};
            foreach (int num in arr0To9)
            {
                // Console.WriteLine(num);
            }
    // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] arrNames = {"Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in arrNames)
            {
                // Console.WriteLine(name);
            }
    // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] arrTrueFalse = {true,false,true,false,true,false,true,false,true,false};
            foreach (bool TF in arrTrueFalse)
            {
                // Console.WriteLine(TF);
            }
// List of Flavors
    // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Swirl");
            flavors.Add("Mint");
    // Output the length of this list after building it
            // Console.WriteLine($"There are {flavors.Count} flavors of ice cfream.");

    // Output the third flavor in the list, then remove this value
            // Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
    // Output the new length of the list (It should just be one fewer!)
            // Console.WriteLine(flavors.Count);
            foreach (string flavor in flavors)
            {
                // Console.WriteLine(flavor);
            }
// User Info Dictionary
    // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> newDict = new Dictionary<string,string>();
    // Add key/value pairs to this dictionary where:
    // each key is a name from your names array
    // each value is a randomly select a flavor from your flavors list.
            Random rando = new Random();
            foreach (string name in arrNames)
            {
                newDict.Add(name, flavors[rando.Next(0, flavors.Count)]);
            }
    // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string, string> entry in newDict)
            {
                Console.WriteLine(entry.Key + " likes " + entry.Value + " ice cream.");
            }
        }
    }
}