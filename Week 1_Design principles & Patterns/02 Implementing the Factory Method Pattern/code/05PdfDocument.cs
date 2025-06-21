namespace Week1_pattern_02;

public class PdfDocument : Document
{
    public void open()
    {
        Console.WriteLine("opening pdfDocument");
    }

    public void close()
    {
        Console.WriteLine("closing pdfDocument");
    }
}