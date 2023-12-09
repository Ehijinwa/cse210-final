public class Workout 
{
    private string _equipment;
    private int _reps;
    private int _exerciseTime;
    private Timer timer = new Timer();


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
    public Timer Timer
    {
        get {return timer;}
    }


    public Workout(string equipment, int exerciseTime, int reps)
    {
        
        
       

        _equipment = equipment;
        
        _exerciseTime = exerciseTime;
        _reps = reps;
    }

    public Workout()
    {

    }

    

    public virtual int CalsBurned()
    {
        // calculate calories burned
        int calsBurned = 42 * 2 * _reps * _exerciseTime;
        return calsBurned;
    }
    public virtual void Start()
    {
        Console.WriteLine("Start doing your exercise");
        timer.Delay(_exerciseTime);
    }
    public virtual void Stop()
    {
        Console.WriteLine("Stop");
        
    }
}