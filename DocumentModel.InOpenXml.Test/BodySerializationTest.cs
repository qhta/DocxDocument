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
    Console.WriteLine("=== Body Sections Enumeration Test ===\n");
    var t0 = DateTime.Now;

    if (!TestBodySerialization(true)) return false;
    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;

    Console.WriteLine("All Body Sections Enumeration Test passed.\n");
    return true;
  }

  /// <summary>
  /// Tests serializing the document body Sections collection.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestBodySerialization(bool verbatim)
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
    var t1 = DateTime.Now;
    //Console.WriteLine($"Open OpenXml file duration: {(t1 - t0).TotalMilliseconds} ms");

    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }


    var t2 = DateTime.Now;

    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    var t3 = DateTime.Now;
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
      string sectionString = SerializeObjectToXml(section, omitXmlDeclaration: true);
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
    Console.WriteLine($"Serialization duration: {(t4 - t3).TotalMilliseconds} ms");
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
