using Week1_pattern_01;

class Program
{
    public static void Main(string[] args)
    {
        LoggerDemo logger1 = LoggerDemo.getInstance();
        LoggerDemo logger2 = LoggerDemo.getInstance();

        Console.WriteLine();

        if (logger1 == logger2)
        {
            // same instacne
            Console.WriteLine("this is the same instance :) " );
        }
        else
        {
            Console.WriteLine("Not the same instance :( ");
            throw new Exception("not singleTone implemented ::");
        }
        
        // checking ::
        logger1.log("Hello my name is souptik karan , printed by logger 1");
        logger2.log("Hello my name is souptik karan , printed by logger 2");

    }
}