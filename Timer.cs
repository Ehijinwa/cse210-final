public class Timer
{
    public Timer()
    {

    }
    public void Delay(int seconds)
    {
        Thread.Sleep(1000 * seconds);
    }

}