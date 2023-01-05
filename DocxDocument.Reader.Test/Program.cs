namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    var testInstance = new TestProperties();
    testInstance.Setup();
    testInstance.TestPropertiesXmlSerialization();
    Console.WriteLine("Test passed");
  }
}