namespace Week1_pattern_02;

public class WordDocumentFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new WordDocument();
    }
}