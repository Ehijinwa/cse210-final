public class Yoga:Workout
{
    public Yoga()
    {
         Console.WriteLine("What equiptment do you want?");
        string equipment = Console.ReadLine();
        Console.WriteLine("How many reps?");
        int reps = int.Parse(Console.ReadLine());
        Console.WriteLine("How long will you be exercising for?");
        int exerciseTime = int.Parse(Console.ReadLine());
        Console.WriteLine("How long is your break time");
        int breakTime = int.Parse(Console.ReadLine());
        this.Equipment = equipment;
        this.Breaktime = breakTime;
        this.Exercisetime = exerciseTime;
        this.Reps = reps;
    }
}