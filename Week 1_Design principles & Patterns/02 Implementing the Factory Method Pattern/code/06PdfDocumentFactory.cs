namespace Week1_pattern_02;

public class PdfDocumentFactory :DocumentFactory
{
    public override Document createDocument()
    {
        return new PdfDocument();
    }
}