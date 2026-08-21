using System.Xml.Linq;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document sections from a sample file.
/// </summary>
public class BodySerializationTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Body Serialization Test ===\n");

    //if (!TestBodyItemsSerialization(false)) return false;
    if (!TestBodyItemsDeserialization(true)) return false;

    Console.WriteLine("All Body Serialization Test passed.\n");
    return true;
  }


  /// <summary>
  /// Tests body items serialization. Xml output is written to a file named "BodySerializationTestOutput.xml" in the same directory as the sample file.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestBodyItemsSerialization(bool verbatim)
  {
    Console.WriteLine($"--- Body items serialization test ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }
    var outputFileName = Path.Combine(Path.GetDirectoryName(SampleFilePath)!, "BodySerializationTestOutput.xml");
    using var outputFile = File.CreateText(outputFileName);

    var t0 = DateTime.Now;
    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    //Console.WriteLine($"Open OpenXml file duration: {(t1 - t0).TotalMilliseconds} ms");

    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }



    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    //Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    var totalItemsCount = 0;
    if (verbatim)
      Console.WriteLine("-------------------------------------------------");
    int itemIndex = 0;
    outputFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
    outputFile.WriteLine("<Body>");
    foreach (var item in modelBody.Items)
    {
      if (verbatim)
        Console.WriteLine($"Item[{itemIndex}] {item}");
      else
        if (itemIndex % 100 == 0)
          Console.Write(".");
      if (item is DMW.Paragraph || item is DMW.SectionProperties)
      {
        var t2 = DateTime.Now;
        string sectionString = SerializeObjectToXml(item, omitXmlDeclaration: true);
        var t3 = DateTime.Now;
        TotalXmlSerialization += (t3 - t2).TotalMilliseconds;
        if (sectionString != string.Empty)
        {
          outputFile.WriteLine(sectionString);
        }
      }
      itemIndex++;
    }
    outputFile.WriteLine("</Body>");
    Console.WriteLine($"\nEnumerated: {itemIndex} items");
    totalItemsCount = itemIndex;
    var t4 = DateTime.Now;
    Console.WriteLine($"Test duration: {(t4 - t0).TotalMilliseconds} ms");
    if (verbatim)
      Console.WriteLine("-------------------------------------------------");

    if (totalItemsCount == 0)
    {
      Console.WriteLine($"✗ Body items count is zero");
      return false;
    }
    Console.WriteLine($"✓ Body items serialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests body items deserialization. Xml input is read from a file named "BodySerializationTestOutput.xml" in the same directory as the sample file.
  /// A temporary copy of the sample file is created with the deserialized body items.
  /// </summary>
  private bool TestBodyItemsDeserialization(bool verbatim)
  {
    Console.WriteLine($"--- Body items deserialization test ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }
    var TempFilePath = Path.Combine(Path.GetDirectoryName(SampleFilePath) ?? string.Empty, Path.GetFileNameWithoutExtension(SampleFilePath) + "_temp" + Path.GetExtension(SampleFilePath));
    File.Copy(SampleFilePath, TempFilePath, true);


    var inputFileName = Path.Combine(Path.GetDirectoryName(SampleFilePath)!, "BodySerializationTestOutput.xml");

    var t0 = DateTime.Now;
    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(TempFilePath, true);
    //Console.WriteLine($"Open OpenXml file duration: {(t1 - t0).TotalMilliseconds} ms");

    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }



    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    //Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    if (verbatim)
      Console.WriteLine("-------------------------------------------------");
    var xDocument = XDocument.Load(inputFileName);
    var root = xDocument.Root;
    if (root == null || root.Name != "Body")
    {
      Console.WriteLine($"✗ Invalid root element. It should be 'Body', but was '{root?.Name}'");
      return false;
    }
    var xmlFileItemsCount = root.Elements().Count();
    if (xmlFileItemsCount == 0)
    {
      Console.WriteLine($"✗ Xml file items count is zero");
    }
    modelBody.Clear();
    Console.WriteLine($"Deserializing Body from {inputFileName}");
    int itemIndex = 0;
    foreach (var element in root.Elements())
    {
      //if (verbatim)
      //  Console.WriteLine($"Deserializing element: {element.Name}");
      var modelElement = DeserializeModelElement(element)!;
      if (verbatim)
        Console.WriteLine($"Item[{itemIndex}]: {modelElement}");
      itemIndex++;
      modelBody.Add(modelElement);
    }
    var itemsCount = modelBody.Items.Count();
    Console.WriteLine($"\nDeserialized: {itemsCount} Items. Xml file items count was: {xmlFileItemsCount}");
    var t4 = DateTime.Now;
    Console.WriteLine($"Test duration: {(t4 - t0).TotalMilliseconds} ms");
    if (verbatim)
      Console.WriteLine("-------------------------------------------------");

    if (itemsCount != xmlFileItemsCount)
    {
      Console.WriteLine($"✗ Body items count mismatch: {itemsCount} vs {xmlFileItemsCount}");
      return false;
    }
    Console.WriteLine($"✓ Serialize Body Sections test passed\n");
    return true;
  }

  /// <summary>
  /// Tests serializing the document body Sections collection.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestBodySectionsSerialization(bool verbatim)
  {
    Console.WriteLine($"--- Serialize Body Sections");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }
    var outputFileName = Path.Combine(Path.GetDirectoryName(SampleFilePath)!, "BodySerializationTestOutput.xml");
    using var outputFile = File.CreateText(outputFileName);

    var t0 = DateTime.Now;

    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    //Console.WriteLine($"Open OpenXml file duration: {(t1 - t0).TotalMilliseconds} ms");

    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }



    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    if (verbatim)
      Console.WriteLine("-------------------------------------------------");
    int sectionIndex = 0;
    int sectionsCount = 0;
    int totalRangeItemsCount = 0;
    outputFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
    outputFile.WriteLine("<Body>");
    foreach (var section in modelBody.Sections)
    {
      //Debug.WriteLine($"Section {sectionIndex}");
      DMW.Range range = section.Range;
      var rangeItems = range.Items;
      var rangeItemsCount = rangeItems.Count();
      totalRangeItemsCount += rangeItemsCount;
      Console.WriteLine($"Section {sectionIndex}");
      if (verbatim)
        Console.WriteLine($"Range: Start={range.Start}, End={range.End}, ItemsCount={rangeItemsCount}");
      var t2 = DateTime.Now;
      string sectionString = SerializeObjectToXml(section, omitXmlDeclaration: true);
      var t3 = DateTime.Now;
      TotalXmlSerialization += (t3 - t2).TotalMilliseconds;
      if (sectionString != string.Empty)
      {
        outputFile.WriteLine(sectionString);
      }
      sectionIndex++;
      sectionsCount++;

    }
    Console.WriteLine($"\nEnumerated: {sectionsCount} Sections with total {totalRangeItemsCount} Range Items");
    var bodyItemsCount = modelBody.Items.Count();
    if (totalRangeItemsCount != bodyItemsCount)
    {
      Console.WriteLine($"✗ Body items count mismatch: {bodyItemsCount} vs {totalRangeItemsCount}");
      return false;
    }
    outputFile.WriteLine("</Body>");
    var t4 = DateTime.Now;
    Console.WriteLine($"Test duration: {(t4 - t0).TotalMilliseconds} ms");
    if (verbatim)
      Console.WriteLine("-------------------------------------------------");


    if (sectionsCount == 0)
    {
      Console.WriteLine($"✗ Body Sections count is zero");
      return false;
    }


    Console.WriteLine($"✓ Serialize Body Sections test passed\n");
    return true;
  }


}
