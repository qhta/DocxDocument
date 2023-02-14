using DocumentModel;

namespace DocxDocument.Reader.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    RunTestFonts();
  }

  private static void RunTestFonts()
  {
    var testInstance = new TestFonts();
    testInstance.Setup();
    //testInstance.TestDocumentFonts();
    testInstance.TestFontsXmlSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestTheme()
  {
    var testInstance = new TestTheme();
    testInstance.Setup();
    //testInstance.TestDocumentTheme();
    testInstance.TestThemeXmlSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestStyles()
  {
    var testInstance = new TestStyles();
    testInstance.Setup();
    //testInstance.TestDocumentStyles();
    testInstance.TestStylesXmlSerialization();
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
    testInstance.TestEnumVariantType();
    //testInstance.TestVariantXmlSerialization();
    //testInstance.TestVectorXmlSerialization();
    Console.WriteLine("Test passed");
  }
}