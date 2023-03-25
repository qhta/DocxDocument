using DocumentModel;
using DocumentModel.Wordprocessing;

namespace DocxDocument.ReadWrite.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    RunTestFonts();
  }

  private static void RunTestSections()
  {
    var testInstance = new TestSections();
    testInstance.Setup();
    //testInstance.TestReadSections();
    testInstance.TestReadSectionsXmlSerialization("_Jakość oprogramowania.docx");
    //testInstance.TestReadSectionsJsonSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestBody()
  {
    var testInstance = new TestBody();
    testInstance.Setup();
    testInstance.TestReadDocumentBody("_Jakość oprogramowania.docx", true);
    testInstance.TestReadBodyXmlSerialization("_Jakość oprogramowania.docx", true);
    //testInstance.TestReadBodyJsonSerialization("Simple text paragraph.docx");
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestFonts()
  {
    var testInstance = new TestFonts();
    testInstance.Setup();
    testInstance.TestReadDocumentFonts();
    testInstance.TestReadFontsXmlSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestTheme()
  {
    var testInstance = new TestTheme();
    testInstance.Setup();
    testInstance.TestReadDocumentTheme();
    testInstance.TestThemeXmlSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestStyles()
  {
    var testInstance = new TestStyles();
    testInstance.Setup();
    testInstance.TestReadDocumentStyles();
    testInstance.TestReadStylesXmlSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestProperties()
  {
    var testInstance = new TestProperties();
    testInstance.Setup();
    testInstance.TestReadDocumentProperties();
    testInstance.TestReadPropertiesXmlSerialization();
    Console.WriteLine("Test passed");
  }

  private static void RunTestConverters()
  {
    var testInstance = new TestConverters();
    testInstance.Setup();
    testInstance.TestHexIntConverter();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestVariants()
  {
    var testInstance = new TestVariants();
    testInstance.Setup();
    //testInstance.TestEnumVariantType();
    testInstance.TestVariantXmlSerialization();
    testInstance.TestVectorXmlSerialization();
    Console.WriteLine("Test passed");
  }
}