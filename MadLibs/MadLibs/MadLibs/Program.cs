﻿using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is going to write a Mad Lib word game!
            Author: Nelson Villegas
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Lib game is starting!");


            // Give the Mad Lib a title:
            string title = "MAD LIBS GAME";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name for the character: ");
            string name = Console.ReadLine();

            Console.Write("Enter the first adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Enter the second adjective: ");
            string adj2 = Console.ReadLine();

            Console.Write("Enter the third adjective: ");
            string adj3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter the first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter the second noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero name: ");
            string superHero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
