namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    var testInstance = new TestConverters();
    testInstance.Setup();
    testInstance.TestEnumOpenXmlLeafElementConverter();
    Console.WriteLine("Test passed");
  }
}