namespace DocxDocument.ReadWrite.Test;

internal class Program
{
  private static void Main(string[] args)
  {
    RunTestProperties();
  }

    private static void RunTestBackground()
  {
    var testInstance = new TestBackground();
    testInstance.Setup();
    testInstance.TestReadBackground("BackgroundColor.docx", true);
    testInstance.TestReadBackgroundXmlSerialization("BackgroundColor.docx", true);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestComments()
  {
    var testInstance = new TestComments();
    testInstance.Setup();
    testInstance.TestReadComments(/*"Comments.docx",true*/);
    testInstance.TestReadCommentsXmlSerialization(/*"Comments.docx", true*/);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestSections()
  {
    var testInstance = new TestSections();
    testInstance.Setup();
    testInstance.TestReadSections(/*"PageSizes.docx",true*/);
    testInstance.TestReadSectionsXmlSerialization(/*"Math.docx", true*/);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestBody()
  {
    var testInstance = new TestBody();
    testInstance.Setup();
    //testInstance.TestReadDocumentBody("Math.docx", true);
    testInstance.TestReadBodyXmlSerialization("_Jakość oprogramowania.docx", true);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestNumbering()
  {
    var testInstance = new TestNumbering();
    testInstance.Setup();
    //testInstance.TestReadNumbering();
    testInstance.TestReadNumberingXmlSerialization("_Jakość oprogramowania.docx", true);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestFonts()
  {
    var testInstance = new TestFonts();
    testInstance.Setup();
    testInstance.TestReadDocumentFonts();
    testInstance.TestReadFontsXmlSerialization("Font embedding.docx", true);
    testInstance.TestReadEmbedFonts("Font embedding.docx", true);
    testInstance.TestReadEmbedFontsXmlSerialization("Font embedding.docx", true);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestTheme()
  {
    var testInstance = new TestTheme();
    testInstance.Setup();
    //testInstance.TestReadDocumentTheme();
    testInstance.TestReadThemeXmlSerialization();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestStyles()
  {
    var testInstance = new TestStyles();
    testInstance.Setup();
    testInstance.TestReadStyles(/*"_Jakość oprogramowania.docx", true*/);
    testInstance.TestReadStylesXmlSerialization(/*"Bookmarks.docx", true*/);
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestProperties()
  {
    var testInstance = new TestProperties();
    testInstance.Setup();
    testInstance.TestReadProperties("DocumentProperties.docx", true);
    //testInstance.TestReadPropertiesXmlSerialization("DocumentProperties.docx", true);
    Console.WriteLine("Test passed");
  }

  private static void RunTestConverters()
  {
    var testInstance = new TestConverters();
    testInstance.Setup();
    testInstance.TestEnumValueConverter();
    Console.WriteLine("\nTest passed");
  }

  private static void RunTestVariants()
  {
    var testInstance = new TestVariants();
    testInstance.Setup();
    testInstance.TestEnumVariantType();
    testInstance.TestVariantXmlSerialization(null, true);
    testInstance.TestVectorXmlSerialization(null,true);
    Console.WriteLine("Test passed");
  }
}