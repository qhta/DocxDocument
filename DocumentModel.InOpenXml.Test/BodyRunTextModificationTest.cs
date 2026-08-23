namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests modifying the document body Run items.
/// </summary>
public class BodyRunTextModificationTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Body Run Items Enumeration Test ===\n");
    var t0 = DateTime.Now;

    if (!TestModifyBodyRunItemsText(true, true, 1)) return false;

    var t1 = DateTime.Now;
    TotalUpdateInOpenXml += (t1 - t0).TotalMilliseconds;
    if (!TestVerifyBodyRunItemsText(true, true, 1)) return false;
    var t2 = DateTime.Now;
    TotalLoadFromOpenXml += (t2 - t1).TotalMilliseconds;

    Console.WriteLine("All Body Run Items Enumeration passed.\n");
    return true;
  }



  /// <summary>
  /// Tests modifying the document body Run items text.
  /// First, it opens the copy of the sample file and loads the document body into a model.
  /// Then, it enumerates through the paragraphs and their items, modifying each Run Text for each item.
  /// The modified data is then saved back to the OpenXml document.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestModifyBodyRunItemsText(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Modify Body Run Items Text with direct access = {directAccess} ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    var TempFilePath = Path.Combine(Path.GetDirectoryName(SampleFilePath) ?? string.Empty, Path.GetFileNameWithoutExtension(SampleFilePath) + "_temp" + Path.GetExtension(SampleFilePath));
    File.Copy(SampleFilePath, TempFilePath, true);

    var t0 = DateTime.Now;
    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(TempFilePath, true);
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

          var paraItemsCount = paraItems.Count();
          totalParaItemsCount += paraItemsCount;
          if (verbatim)
            Console.WriteLine($"Paragraph[{paragraphIndex}]: ID={paraId} ItemsCount={paraItemsCount}");
          if (!paraItems.IsEmpty())
          {
            var itemIndex = 0;
            foreach (var paraItem in paraItems)
            {
              var paraItemStr = paraItem.ToString();

              if (paraItem is Run run)
              {
                if (verbatim)
                  Console.WriteLine($"  Item[{itemIndex++}] {paraItemStr}");
                if (run.Items.Count > 1 || run.Items.FirstOrDefault() is not RunText)
                {
                  foreach (var runItem in run.Items)
                  {
                    var runItemStr = runItem.ToString();
                    if (verbatim)
                      Console.WriteLine($"    RunItem[{itemIndex++}] {runItemStr}");
                  }
                }
                //if (run.Items.Count > 0)
                {
                  var text = run.Text;
                  text = "|" + text + "|";
                  run.Text = text;
                  if (run.Text != text)
                  {
                    Console.WriteLine($"✗ Run Text modification failed for Paragraph[{paragraphIndex}] Item[{itemIndex - 1}]");
                    return false;
                  }
                }
              }
              else
              {
                if (verbatim)
                  Console.WriteLine($"  Item[{itemIndex++}] {paraItemStr}");
              }
            }
          }

          if (!verbatim)
          {
            if (paragraphIndex % 100 == 0)
              Console.Write(".");
          }
          paragraphIndex++;
          var t6 = DateTime.Now;
          paraTimeSpan.Add(t6 - t5);
        }
      }
      Console.WriteLine($"\nEnumerated: {paragraphIndex} paragraphs, total {totalParaItemsCount} paragraph items");
      if (paraTimeSpan.Any())
        Console.WriteLine($"Mean Paragraph read duration: {paraTimeSpan.Average(t => t.TotalMilliseconds)} ms");
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
    Console.WriteLine($"✓ Modify Body Run Items Text with direct access = {directAccess} test passed\n");
    return true;
  }

  /// <summary>
  /// Tests verifying the document body Run items text.
  /// First, it opens the copy of the sample file and loads the document body into a model.
  /// Then, it enumerates through the paragraphs and their items, verifying each Run Text for each item.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestVerifyBodyRunItemsText(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Verify Body Run Items Text with direct access = {directAccess} ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    var TempFilePath = Path.Combine(Path.GetDirectoryName(SampleFilePath) ?? string.Empty, Path.GetFileNameWithoutExtension(SampleFilePath) + "_temp" + Path.GetExtension(SampleFilePath));
    File.Copy(SampleFilePath, TempFilePath, true);

    var t0 = DateTime.Now;
    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(TempFilePath, false);
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

          var paraItemsCount = paraItems.Count();
          totalParaItemsCount += paraItemsCount;
          if (verbatim)
            Console.WriteLine($"Paragraph[{paragraphIndex}]: ID={paraId} ItemsCount={paraItemsCount}");
          if (!paraItems.IsEmpty())
          {
            var itemIndex = 0;
            foreach (var paraItem in paraItems)
            {
              var paraItemStr = paraItem.ToString();

              if (paraItem is Run run)
              {
                if (verbatim)
                  Console.WriteLine($"  Item[{itemIndex++}] {paraItemStr}");
                if (run.Items.Count > 1 || run.Items.FirstOrDefault() is not RunText)
                {
                  foreach (var runItem in run.Items)
                  {
                    var runItemStr = runItem.ToString();
                    if (verbatim)
                      Console.WriteLine($"    RunItem[{itemIndex++}] {runItemStr}");
                  }
                }
                //if (run.Items.Count > 0)
                {
                  var text = run.Text!;
                  if (!text.StartsWith("|") || !text.EndsWith("|"))
                  {
                    Console.WriteLine($"✗ Run Text verification failed for Paragraph[{paragraphIndex}] Item[{itemIndex - 1}]");
                    return false;
                  }
                }
              }
              else
              {
                if (verbatim)
                  Console.WriteLine($"  Item[{itemIndex++}] {paraItemStr}");
              }
            }
          }

          if (!verbatim)
          {
            if (paragraphIndex % 100 == 0)
              Console.Write(".");
          }
          paragraphIndex++;
          var t6 = DateTime.Now;
          paraTimeSpan.Add(t6 - t5);
        }
      }
      Console.WriteLine($"\nEnumerated: {paragraphIndex} paragraphs, total {totalParaItemsCount} paragraph items");
      if (paraTimeSpan.Any())
        Console.WriteLine($"Mean Paragraph read duration: {paraTimeSpan.Average(t => t.TotalMilliseconds)} ms");
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

    Console.WriteLine($"✓ Verify Body Run Items Text with direct access = {directAccess} test passed\n");
    return true;
  }


}
