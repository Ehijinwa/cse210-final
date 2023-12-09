public class Stretching : Workout
{
    public Stretching()
    {
        
        string equipment = "No Equipment";
        Console.WriteLine("How many reps?");
        int reps = int.Parse(Console.ReadLine());
        Console.WriteLine("How long will you be stretching for?");
        int exerciseTime = int.Parse(Console.ReadLine());
        
        this.Equipment = equipment;
        
        this.Exercisetime = exerciseTime;
        this.Reps = reps;
    }
    public override int CalsBurned()
    {
        int calsBurned = 42 * 2  * this.Exercisetime;
        return calsBurned;
        
    }
    public override void Start()
    {
        Console.WriteLine("Start doing your exercise");
        this.Timer.Delay(this.Exercisetime);
    }
    public override void Stop()
    {
         Console.WriteLine("Stop Stretching");
    }
}