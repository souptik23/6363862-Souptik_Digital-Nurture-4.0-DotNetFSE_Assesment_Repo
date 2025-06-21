namespace Week1_pattern_02;

public class ExcelDocument : Document
{
    public void open()
    {
        Console.WriteLine("opening excel document");
    }

    public void close()
    {
        Console.WriteLine("closing excel document");
    }
}