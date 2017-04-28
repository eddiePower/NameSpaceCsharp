using NameSpacesExample.Model;
using System;
using System.Collections.Generic;

namespace NameSpacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new list of produce items
            var produce = new List<object>();

            //add a fruit item to memory
            var f1 = new Fruit("Apple", 8.5, 3);
            //add the fruit item to produce list
            produce.Add(f1);

            //create a second fruit item and add it to produce list
            var f2 = new Fruit("Bannana", 4.5, 7);
            produce.Add(f2);

            //add a new vegtable item to the produce list
            produce.Add(new Vegetable("Carrot", 4.1, 16));

            //output the total number of items in the produce list
            Console.WriteLine("There are " + produce.Count + " items in produce");
            
            //loop over each item in the prod list and output it to the screen
            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }

            //give the user a how to exit comment while pausing to show output
            //when not in debug mode.
            Console.WriteLine("\nHit Enter to Exit! :)");
            Console.ReadLine();
        }
    }
}
