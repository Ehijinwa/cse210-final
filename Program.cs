using System;
using System.ComponentModel.Design;
using System.IO;

class Program
{
   
    static void Main(string[] args)
    {
        Records records = new Records();
         Console.Clear();
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("    1. Workout");
            Console.WriteLine("    2. Save");
            Console.WriteLine("    3. Load");
            Console.WriteLine("    4. New Summary");
            Console.WriteLine("    5. Display Summaries");
            Console.WriteLine("    6. End");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            
            if(choice=="1")
            {
                Console.WriteLine("What kind of workout do you want to do?");
                Console.WriteLine("    1. Custom");
                Console.WriteLine("    2. Yoga");
                Console.WriteLine("    3. Cycling");
                Console.WriteLine("    4. Stretching");
                string choice2 =Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("What equiptment do you want?");
                    string equipment = Console.ReadLine();
                    Console.WriteLine("How many reps?");
                    int reps = int.Parse(Console.ReadLine());
                    Console.WriteLine("How long will you be exercising for in seconds?");
                    int exerciseTime = int.Parse(Console.ReadLine());
                    Workout workout = new Workout(equipment,exerciseTime,reps);
                    workout.Start();
                    workout.Stop();
                }
                else if (choice2== "2") 
                {
                    Yoga yoga = new Yoga();
                    yoga.Start();
                    yoga.Stop();
                }
                else if (choice2== "3")
                {
                    Cycling cycling = new Cycling();
                    cycling.Start();
                    cycling.Stop();
                }
                else if (choice2== "4")
                {
                    Stretching stretching = new Stretching();
                    stretching.Start();
                    stretching.Stop();
                }

            }
            else if (choice=="2")
            {
                Save.SaveEntriesToFile(records.summaries);
            }
            else if (choice=="3")
            {
                records.summaries = Save.ReadEntriesFromFile();
            }
            else if (choice=="4")
            {
                string prompt = records.GetPrompt();
                Console.WriteLine(prompt);
                records.AddEntry(prompt,records.GetResponse());
            }
            else if (choice=="5")
            {
                records.Display();
            }
        }
    }
}