namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests enumerating the document body items;
/// </summary>
public class BodyItemsEnumerationTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Body Items Enumeration Test ===\n");
    var t0 = DateTime.Now;
    //if (!TestCountBodyItems(true, 1)) return false;
    ////if (!TestCountBodyItems(false, 1)) return false;

    //if (!TestCheckBodyEmpty(true, 1)) return false;
    ////if (!TestCheckBodyEmpty(false, 1)) return false;

    if (!TestEnumerateBodyItems(true, false, 1)) return false;
    //if (!TestEnumerateBodyItems(false, false, 1)) return false;

    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;

    Console.WriteLine("All Body Items Enumeration passed.\n");
    return true;
  }

  /// <summary>
  /// Tests checking document body items count.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestCountBodyItems(bool directAccess, int times = 1)
  {
    Console.WriteLine($"--- Count Body items with direct access = {directAccess} ---");

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


    var openXmlCount = openXmlBody.ChildElements.Count;
    var t2 = DateTime.Now;
    Console.WriteLine($"OpenXml body elements count: {openXmlCount}");
    //Console.WriteLine($"Get OpenXml body elements count duration: {(t2 - t1).TotalMilliseconds} ms");

    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    modelBody.SetHasDirectAccess(directAccess);
    var t3 = DateTime.Now;
    //Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    for (int trial = 0; trial < times; trial++)
    {
      var modelCount = modelBody.Items.Count;
      var t4 = DateTime.Now;
      Console.WriteLine($"Model body elements count: {modelCount}");
      //Console.WriteLine($"Get Model items elements count duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (modelCount != openXmlCount)
      {
        Console.WriteLine($"✗ Body items count mismatch: model={modelCount}, openXml={openXmlCount}");
        return false;
      }
    }

    Console.WriteLine($"✓ Count Body items with direct access = {directAccess} test passed\n");
    return true;
  }

  /// <summary>
  /// Tests checking if the document body is empty.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestCheckBodyEmpty(bool directAccess, int times = 1)
  {
    Console.WriteLine($"--- Check if Body is empty with direct access = {directAccess} ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    var t0 = DateTime.Now;
    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    var t1 = DateTime.Now;
   // Console.WriteLine($"Open OpenXml file duration: {(t1 - t0).TotalMilliseconds} ms");

    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }


    var openXmlIsEmpty = !openXmlBody.ChildElements.Any();
    var t2 = DateTime.Now;
    Console.WriteLine($"OpenXml body is empty: {openXmlIsEmpty}");
    //Console.WriteLine($"Check OpenXml body elements is empty duration: {(t2 - t1).TotalMilliseconds} ms");

    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    modelBody.SetHasDirectAccess(directAccess);
    var t3 = DateTime.Now;
    //Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    for (int trial = 0; trial < times; trial++)
    {
      var modelCountIsEmpty = modelBody.Items.IsEmpty();
      var t4 = DateTime.Now;
      Console.WriteLine($"Model body is empty: {modelCountIsEmpty}");
      //Console.WriteLine($"Get Model items is empty duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (modelCountIsEmpty != openXmlIsEmpty)
      {
        Console.WriteLine($"✗ Body items count mismatch: model={modelCountIsEmpty}, openXml={openXmlIsEmpty}");
        return false;
      }
    }

    Console.WriteLine($"✓ Check if Body is empty with direct access = {directAccess} test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body items (shallow enumeration).
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyItems(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body items with direct access = {directAccess} ---");

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
    var lastItemsCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int itemIndex = 0;
      foreach (var item in modelBody.Items)
      {
        if (verbatim)
          Console.WriteLine($"{trial}.{itemIndex}: {item.GetType().Name}");
        itemIndex++;
      }
      Console.WriteLine($"Enumerated: {itemIndex} items");
      if (trial == 0)
        lastItemsCount = itemIndex;
      else if (itemIndex != lastItemsCount)
      {
        Console.WriteLine($"✗ Body items count mismatch between iterations: {lastItemsCount} vs {itemIndex}");
        return false;
      }
      var t4 = DateTime.Now;
      //Console.WriteLine($"Get Model items duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
    }

    if (lastItemsCount == 0)
    {
      Console.WriteLine($"✗ Body items count is zero");
      return false;
    }
    Console.WriteLine($"✓ Enumerate Body items with direct access = {directAccess} test passed\n");
    return true;
  }

}
