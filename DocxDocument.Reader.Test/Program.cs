namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    var testInstance = new TestVariants();
    testInstance.Setup();
    testInstance.TestXmlArrayVariantSerialization();
    Console.WriteLine("Test passed");
  }
}