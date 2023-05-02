namespace DocxEx.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    RunTestSections();
  }

  private static void RunTestSections()
  {
    var testInstance = new TestSections();
    testInstance.Setup();
    testInstance.TestReadDocumentSections("_Jakość oprogramowania.docx");
    //testInstance.TestCleanDocumentSections("_Jakość oprogramowania.docx", true, true);
    Console.WriteLine("\nTest passed");
  }

}