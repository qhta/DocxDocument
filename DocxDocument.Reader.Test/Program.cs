namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    var testInstance = new TestStyles();
    testInstance.Setup();
    testInstance.TestDocumentStyles ();
    Console.WriteLine("\nTest passed");
  }

  //private static void Main(string[] args)
  //{
  //  var testInstance = new TestConverters();
  //  testInstance.Setup();
  //  testInstance.TestHexBinaryConverter(true);
  //  Console.WriteLine("\nTest passed");
  //}

  //private static void Main(string[] args)
  //{
  //  var testInstance = new TestVariants();
  //  testInstance.Setup();
  //  testInstance.TestXmlVectorVariantSerialization();
  //  Console.WriteLine("Test passed");
  //}
}