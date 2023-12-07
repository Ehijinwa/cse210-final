using System;
using System.ComponentModel.Design;
using System.IO;

class Program
{
   
    static void Main(string[] args)
    {
         Console.Clear();
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("    1. Setup Workout");
            Console.WriteLine("    2. Begin Workout");
            Console.WriteLine("    3. Save");
            Console.WriteLine("    4. Load");
            Console.WriteLine("    5. New Summary");
            Console.WriteLine("    6. End");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            
            if(choice=="1")
            {
                Workout workout = new Workout();
            }
        }
    }
}