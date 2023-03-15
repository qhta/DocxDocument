namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    //var ok = typeof(Fonts).IsCollection(out var itemType);
    //Console.WriteLine($"{ok} {itemType}");
    RunTestSections();
  }

  private static void RunTestSections()
  {
    var testInstance = new TestSections();
    testInstance.Setup();
    //testInstance.TestReadDocumentBody();
    testInstance.TestReadDocumentSections("_Jakość oprogramowania.docx");
    //testInstance.TestReadBodyJsonSerialization(/*"Simple text paragraph.docx"*/);
    Console.WriteLine("\nTest passed");
  }

}