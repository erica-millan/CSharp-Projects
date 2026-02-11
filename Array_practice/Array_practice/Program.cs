using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one dim array of strings
            string[] array = { "A", "B", "C", "D", "E", "F" };
            //have to assign local variable 
            int selectedIndex = 0;
            //creating a bool set it equal to false
            bool validInput = false;
            //while validInput (which is false) is !validInput which equals true the loop will keep going
            //since a true result keeps loop going
            while (!validInput)
            {
                //getting index from user
                Console.WriteLine("select an index of the array from 0-5");
                //the converting to int and retrieving variable selected index from user
                selectedIndex = Convert.ToInt32(Console.ReadLine());
                //checking to see if it's between 0 and 5, if it is i set showString to true which will 
                //then be negated to be false to escape the loop.
                if (selectedIndex >= 0 && selectedIndex <= 5)
                {
                    validInput = true;
                }
                else
                {
                    //otherwise we remain in loop and keep prompting user for an index
                    Console.WriteLine("Index selected is not in range.");
                }
            }
            //when loop breaks we show the selected index
            Console.WriteLine("The string at index: " + selectedIndex + " is " + array[selectedIndex]);

            //one dim array of ints
            int[] array2 = { 20, 21, 22, 23, 24, 25 };
            int selectedIndex2 = 0;
            //creating a bool setting it = false for now
            bool validInput_ = false;
            //creating a while group that negates is valid so it's true so it will continue while loop
            while (!validInput_)
            {   //getting index selection from user      
                Console.WriteLine("select an index of the array from 0-5");
                selectedIndex2 = Convert.ToInt32(Console.ReadLine());
                //if the selected index is in range
                if (selectedIndex2 >= 0 && selectedIndex2 <= 5)
                {
                    //set validInput to true, it will be set to false with the "!" and escape loop.
                    validInput_ = true;
                }
                else
                {
                    //if not in range then tell user and re-enter the loop.
                    Console.WriteLine("Invalid input please enter a number between 0 and 5");
                }

            }
            Console.WriteLine("The integer at index: " + selectedIndex2 + " is " + array2[selectedIndex2]);

            //creating a list object named list and initializing it with the new keyword
            List<string> list = new List<string>();
            //adding data to the list
            list.Add("Purple");
            list.Add("Pink");
            list.Add("Red");
            list.Add("Orange");
            list.Add("Blue");
            //initalizing local variable
            int selectedIndex3 = 0;
            //creating a bool setting equal to false
            bool isValid__ = false;
            //while the bool is  !isValid it will be true and keep running loop
            while (!isValid__)
            {
                //getting selection from user storing it in variable
                Console.WriteLine("Choose a number from 0-4 for a color");
                selectedIndex3 = Convert.ToInt32(Console.ReadLine());
                //if the selected index is in range
                if (selectedIndex3 >= 0 && selectedIndex3 <= 4)
                {
                    //set isValid equal to true to break loop
                    isValid__ = true;
                }
                //else keep looping (back to top prompting user for a selection)
                else
                {
                 
                Console.WriteLine("invalid input.");
                    
                }
            }
            //escaped loop can output the corresponding index
            Console.WriteLine(list[selectedIndex3]);
        }
    }
}
