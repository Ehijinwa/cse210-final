public class Workout 
{
    private string _equipment;
    private int _reps;
    private int _exerciseTime;
    private int _breakTime;

    public string Equipment
    {
        get {return _equipment;}
        set {_equipment = value;}
    }
    public int Reps
    {
        get {return _reps;}
        set {_reps = value;}
    }
    public int Exercisetime
    {
        get {return _exerciseTime;}
        set {_exerciseTime = value;}
    }
    public int Breaktime
    {
        get {return _breakTime;}
        set {_breakTime = value;}
    }

    public Workout()
    {
        Console.WriteLine("What equiptment do you want?");
        string equipment = Console.ReadLine();
        Console.WriteLine("How many reps?");
        int reps = int.Parse(Console.ReadLine());
        Console.WriteLine("How long will you be exercising for?");
        int exerciseTime = int.Parse(Console.ReadLine());
        Console.WriteLine("How long is your break time");
        int breakTime = int.Parse(Console.ReadLine());
        _equipment = equipment;
        _breakTime = breakTime;
        _exerciseTime = exerciseTime;
        _reps = reps;
    }

    

    public int CalsBurned()
    {
        // calculate calories burned
        return 1;
    }
    public void Start()
    {
        
    }
    public void Stop()
    {

    }
}