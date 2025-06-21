namespace Week1_pattern_01;

public class LoggerDemo
{
    private static LoggerDemo instance;
    private static readonly object padlock = new object();  // using it as a padlock, cant reassigned

    private LoggerDemo()
    {
        
    }

    public static LoggerDemo getInstance()
    {
        if (instance == null)  // first check , 
        {
            lock (padlock) // then locking
            {
                if (instance == null) // second check
                {
                    instance = new LoggerDemo();  // object creation..
                }
            }
        }
        return instance;
    }


    public void log(String message)
    {
        Console.WriteLine("logging: "+message);
    }
}