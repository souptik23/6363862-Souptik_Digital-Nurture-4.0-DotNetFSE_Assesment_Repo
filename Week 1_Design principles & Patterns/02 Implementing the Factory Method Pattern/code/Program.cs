using Week1_pattern_02;

class Program
{
    public static void Main(string[] args)
    {
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Document pdfDocument = pdfFactory.createDocument();
        pdfDocument.open();
        pdfDocument.close();
        Console.WriteLine();
        
        DocumentFactory wordDocumentFactory = new WordDocumentFactory();
        Document wordDocument = wordDocumentFactory.createDocument();
        wordDocument.open();
        wordDocument.close();
        Console.WriteLine();
        
        DocumentFactory excelDocumentFactory = new ExcelDocumentFactory();
        Document excelDocument = excelDocumentFactory.createDocument();
        excelDocument.open();
        excelDocument.close();
        Console.WriteLine();
        
    }
}