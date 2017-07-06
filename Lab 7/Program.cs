using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which student would you like to learn more about?(enter a number 1-13");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 13)
            {
                Console.WriteLine($"Student {input} is {firstname[input]} {lastname[input]}.");
            }
            else
            {
                Console.WriteLine("Student does not exist. Please enter a number between 1 and 13.");
            }

            Console.WriteLine($"What would you like to learn about {firstname[input]}? (enter 'hometown' or 'favorite food'): ");
            string moreinfo = Console.ReadLine();
            moreinfo = moreinfo.ToLower();

            List<string> firstnames = new List<string>();
            firstnames.Add("Ryan");
            firstnames.Add("Josh");
            firstnames.Add("Jill-Ann");
            firstnames.Add("Christopher");
            firstnames.Add("Tori");
            firstnames.Add("Stephanie");
            firstnames.Add("Arianna");
            firstnames.Add("JJ");
            firstnames.Add("Diane");
            firstnames.Add("Megan");
            firstnames.Add("Sabrina");
            firstnames.Add("Tommy");
            firstnames.Add("Doreen");


            List<string> location = new List<string>();

            location.Add("Grand Rapids");
            location.Add("Toronto");
            location.Add("New York");
            location.Add("Chicago");
            location.Add("Los Angeles");
            location.Add("San Antonio");
            location.Add("Sacramento");
            location.Add("Baltimore");
            location.Add("Detroit");
            location.Add("Houston");
            location.Add("Miami");
            location.Add("Raleigh");
            location.Add("Memphis");


            List<string> food = new List<string>();


            food.Add("Cookie");
            food.Add("Oranges");
            food.Add("Apples");
            food.Add("Tacos");
            food.Add("Steak");
            food.Add("Spaghetti");
            food.Add("Pears");
            food.Add("Potato Chips");
            food.Add("Bananas");
            food.Add("Grapes");
            food.Add("Hot Wings");
            food.Add("Chicken");
            food.Add("Turkey");

           

        }
    }
}
