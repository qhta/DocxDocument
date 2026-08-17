namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document body from a sample file and serializing created DocumentModel elements.
/// </summary>
public class BodyParagraphsItemsEnumerationTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Body Paragraphs items Enumeration Test ===\n");
    var t0 = DateTime.Now;

    if (!TestEnumerateBodyParagraphItems(true, true, 1)) return false;
    if (!TestEnumerateBodyParagraphItems(false, false, 2)) return false;

    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;

    Console.WriteLine("All Body Paragraphs Items Enumeration passed.\n");
    return true;
  }



  /// <summary>
  /// Tests enumerating the document body Paragraph Properties data read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyParagraphItems(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Paragraphs Items with direct access = {directAccess} ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    var t0 = DateTime.Now;
    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    var t1 = DateTime.Now;
    Console.WriteLine($"Open OpenXml file duration: {(t1 - t0).TotalMilliseconds} ms");

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
    Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    var lastParagraphsCount = 0;
    int lastParagraphItemsCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int paragraphIndex = 0;
      int totalParaItemsCount = 0;
      List<TimeSpan> paraTimeSpan = new List<TimeSpan>();
      foreach (var item in modelBody.Paragraphs)
      {
        // get shallow data for Paragraph items
        if (item is Paragraph paragraph)
        {
          var paraId = paragraph.ParagraphId;
          var t5 = DateTime.Now;
          var paraItems = paragraph.Items;
          var t6 = DateTime.Now;
          paraTimeSpan.Add(t6 - t5);
          var paraItemsCount = paraItems.Count();
          totalParaItemsCount += paraItemsCount;
          if (verbatim)
          {
            Console.WriteLine($"Paragraph[{paragraphIndex}]: ID={paraId} ItemsCount={paraItemsCount}");
            if (!paraItems.IsEmpty())
            {
              var itemIndex = 0;
              foreach (var paraItem in paraItems)
                Console.WriteLine($"  Item[{itemIndex++}] {paraItem}");
            }
          }
          else
          {
            if (paragraphIndex % 100 == 0)
              Console.Write(".");
          }
          paragraphIndex++;
        }
      }
      Console.WriteLine($"\nEnumerated: {paragraphIndex} paragraphs, total {totalParaItemsCount} paragraph items");
      if (paraTimeSpan.Any())
        Console.WriteLine($" Mean Paragraph Properties read duration: {paraTimeSpan.Average(t => t.TotalMilliseconds)} ms");
      if (trial == 0)
      {
        lastParagraphsCount = paragraphIndex;
        lastParagraphItemsCount = totalParaItemsCount;

      }
      else if (paragraphIndex != lastParagraphsCount)
      {
        Console.WriteLine($"✗ Body items count mismatch between iterations: {lastParagraphsCount} vs {paragraphIndex}");
        return false;
      }

      var t4 = DateTime.Now;
      Console.WriteLine($"Get Model items duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
    }
    if (lastParagraphsCount == 0)
    {
      Console.WriteLine($"✗ Body paragraphs count is zero");
      return false;
    }

    if (lastParagraphItemsCount == 0)
    {
      Console.WriteLine($"✗ Total paragraph items count is zero");
      return false;
    }

    Console.WriteLine($"✓ Enumerate Body Paragraphs Items with direct access = {directAccess} test passed\n");
    return true;
  }


}
