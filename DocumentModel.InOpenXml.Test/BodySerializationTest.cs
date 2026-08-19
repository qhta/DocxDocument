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

    if (!TestBodySerialization(true, true, 1)) return false;
    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;

    Console.WriteLine("All Body Sections Enumeration Test passed.\n");
    return true;
  }

  /// <summary>
  /// Tests serializing the document body Sections collection.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestBodySerialization(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Serialize Body Sections with direct access = {directAccess} ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

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
    modelBody.SetHasDirectAccess(directAccess);
    var t3 = DateTime.Now;
    //Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    int lastSectionsCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int sectionIndex = 0;
      int sectionsCount = 0;
      int totalRangeItemsCount = 0;
      foreach (var section in modelBody.Sections)
      {
        //Debug.WriteLine($"Section {sectionIndex}");
        DMW.Range range = section.Range;
        var rangeItems = range.Items;
        var rangeItemsCount = rangeItems.Count();
        totalRangeItemsCount += rangeItemsCount;
        Console.WriteLine($"Section {sectionIndex}");
        if (section.Paragraph != null)
          Console.WriteLine($"Paragraph ID: {section.Paragraph.ParagraphId}");
        if (verbatim)
        {
          string sectionString = SerializeObjectToXml(section, omitXmlDeclaration: true);
          if (sectionString != string.Empty)
            Console.WriteLine(sectionString);
        }
        Console.WriteLine($"Range: Start={range.Start}, End={range.End}, ItemsCount={rangeItemsCount}");
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

      if (trial == 0)
      {
        lastSectionsCount = sectionsCount;
      }

      var t4 = DateTime.Now;
      //Console.WriteLine($"Get Model items duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
    }

    if (lastSectionsCount == 0)
    {
      Console.WriteLine($"✗ Body Sections count is zero");
      return false;
    }


    Console.WriteLine($"✓ Serialize Body Sections with direct access = {directAccess} test passed\n");
    return true;
  }


}
