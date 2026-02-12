using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment1
            //create string array
            string[] array_ = { "s1", "s2", "s3", "s4", "s5" };
            //prompt user for input
            Console.WriteLine("Hello, insert text that you want to be added to each index of an array.");
            //storing input in variable
            string userInput = Console.ReadLine();

            //have to use a for loop to change the actual array (foreach loop changes a copy of each element)
            //for loop with 3 conditions. i variable starts at 0, loop will go until i is greater array_.length
            //each iteration increment i
            for (int i = 0; i < array_.Length; i++)
            {
                //in the loop set array_[i] which will start at index 0 = to itself plus user input
                //keep incrementing until end of the list
                array_[i] += userInput;
                // Console.WriteLine(array_[i]);
            }

            //creating a foreach  loop to iterate through each item in array_ to print it to the console
            foreach (string item in array_)
            {
                Console.WriteLine(item);
            }

            //Assignment 2
            //infinite for loop
            /* i >= 0 will always be true as long as i increemnts
            for(int i = 0; i >=0; i++)
            {
                Console.WriteLine("Lets crash your program today");
            }
            */
            //fixing infinite for loop by making i <= 10 instead of i >= 0. 
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Lets crash your program today");
            }




            //Assignment 3
            //adding loop that uses a comparison operator to determine whether to continue
            //creating an array 
            int[] testScores = { 85, 98, 47, 0, 48 };
            //while variable k is less than the length of the array run the loop
            Console.WriteLine("Failing test scores: ");
            for (int k = 0; k < testScores.Length; k++)
            {
                // checking if the test score is a passing test score. Only failing test scores (under 84) 
                //will output
                if (testScores[k] <= 84)
                {
                    Console.WriteLine(testScores[k]);
                }
            }

            //using the <= operator in a for loop to output all grades
            Console.WriteLine("all test scores:");
            for (int k = 0; k <= testScores.Length - 1; k++)
            {
                Console.WriteLine(testScores[k]);
            }

            //Assignment 4
            //list of strings all items are unique
            List<string> stringList = new List<string>()
            {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            bool inputValid = false;
            //do while loop so the loop runs at least once
            do
            {
                Console.WriteLine("Type a letter to see the index of the array.");
                string userInput4 = Console.ReadLine();
                //checking to see if user input is on the list
                for (int l = 0; l < stringList.Count; l++)
                {
                    if (userInput4 == stringList[l])
                    {
                        inputValid = true;
                        Console.WriteLine("The index for the letter you selected is: " + l);
                    }
                }
                //if it's not valid output the letter wasn't on the list
                if (!inputValid)
                {
                    Console.WriteLine("Sorry, the letter you added wasn't on the list.");
                }

            }
            //escape loop when !inputvalid = false
            while (!inputValid);


            //Assignment 5
            //string list with duplicates
            List<string> listPets = new List<string>() { "cat", "dog", "bird", "fish", "ferret", "rabbit", "hamster", "snake", "dog" };
            //getting and storing user input
            Console.WriteLine("Type an animal that would be a pet:");
            string userSelection4 = Console.ReadLine();
            //creating a bool so I can check later if the input was in the list
            bool isValid5 = false;
            //looping to iterate through the list
            for (int m = 0; m < listPets.Count; m++)
            {
                //need to set to lower in case there's upper case
                if (userSelection4.ToLower() == listPets[m])
                {
                    //outputting users selection if it's in the list and setting isVald=true
                    Console.WriteLine("The index of your selection is: " + m);
                    isValid5 = true;

                }
            }
            //if isValid stays false it will negate to true outputting this message.
            if (!isValid5)
            {
                Console.WriteLine("Sorry, your input was not on the list.");
            }

            //Assignment 6

            //list with duplicates
            List<string> cokeProducts = new List<string>() { "Coca-Cola", "Diet Coke", "Fanta", "Coca-Cola", "Sprite", "Mellow Yellow", "Root Beer", "Sprite", "Fanta" };
            //this list will keep track of the duplicate items
            List<string> evaluated = new List<string>();
            //going to loop through each item in cokeProducts
            foreach (string drink in cokeProducts)
            {   //checking to see if the list contains item
                if (evaluated.Contains(drink))
                {
                    Console.WriteLine(drink + "- this item is a duplicate.");
                }
                //if not say it's unique
                else
                {
                    Console.WriteLine(drink + "- this item is unique");
                    //add it to evaluated list
                    evaluated.Add(drink);
                }
            }
        }
    }
}
