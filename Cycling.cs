public class Cycling : Workout
{
    private int _distance;
    public Cycling ()
    {
        Console.WriteLine("Equipment is Bicycle");
        string equipment = "Bicycle";
        Console.WriteLine("How far do you want to go?");
        _distance = int.Parse(Console.ReadLine());
        this.Equipment = equipment;
    }
    public override void Start()
    {
        Console.WriteLine("Start doing your exercise");
        this.Timer.Delay(_distance);
    }
    public override void Stop()
    {
        Console.WriteLine("Stop Cycling");
        
    }
    public override int CalsBurned()
    {
        int calsBurned = 42 * 2  * _distance;
        return calsBurned;
        
    }
}
