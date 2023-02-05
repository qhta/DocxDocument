using DocumentModel;

namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    RunTestProperties();
  }

  private static void RunTestStyles()
  {
    var testInstance = new TestStyles();
    testInstance.Setup();
    testInstance.TestDocumentStyles ();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestProperties()
  {
    var testInstance = new TestProperties();
    testInstance.Setup();
    testInstance.TestPropertiesXmlSerialization();
    Console.WriteLine("Test passed");
  }


  private static void RunTestConverters()
  {
    var testInstance = new TestConverters();
    testInstance.Setup();
    testInstance.TestHexBinaryConverter(true);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestVariants()
  {
    var testInstance = new TestVariants();
    testInstance.Setup();
    //testInstance.TestInternalVariantType();
    //testInstance.TestVariantXmlSerialization(VariantType.Blob);
    testInstance.TestVectorXmlSerialization(VariantType.Enum);
    Console.WriteLine("Test passed");
  }
}