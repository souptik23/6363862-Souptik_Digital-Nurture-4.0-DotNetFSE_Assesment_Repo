namespace Week1_pattern_02;

public class ExcelDocumentFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new ExcelDocument();
    }
}