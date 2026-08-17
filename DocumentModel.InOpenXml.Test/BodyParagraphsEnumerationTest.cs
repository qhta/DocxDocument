using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document body from a sample file and serializing created DocumentModel elements.
/// </summary>
public class BodyParagraphsEnumerationTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Body Paragraphs Enumeration Test ===\n");
    var t0 = DateTime.Now;

    //if (!TestEnumerateBodyParagraphWithShallowDataRead(true, false, 2)) return false;
    //if (!TestEnumerateBodyParagraphWithShallowDataRead(false, false, 2)) return false;

    if (!TestEnumerateBodyParagraphPropertiesRead(true, true, 1)) return false;
    if (!TestEnumerateBodyParagraphPropertiesRead(false, false, 2)) return false;

    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;

    Console.WriteLine("All Body Paragraphs Enumeration passed.\n");
    return true;
  }

  /// <summary>
  /// Tests enumerating the document body Paragraph items with shallow data read (without loading full data for each Paragraph).
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyParagraphWithShallowDataRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Paragraphs with shallow direct access = {directAccess} ---");

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
    int lastParagraphIdsCount = 0;
    int lastTextIdsCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int paragraphIndex = 0;
      int paraIdsCount = 0;
      int textIdsCount = 0;
      int additionIdsCount = 0;
      int deletionIdsCount = 0;
      int propertiesIdsCount = 0;
      int runAdditionIdsCount = 0;
      int markIdsCount = 0;
      int noSpellErrorsCount = 0;
      List<HexInt> paraIds = new List<HexInt>();
      foreach (var item in modelBody.Paragraphs)
      {
        if (verbatim)
        {
          Console.WriteLine($"{trial}.{paragraphIndex}: {item.GetType().Name}");
        }
        // get shallow data for Paragraph items
        if (item is Paragraph paragraph)
        {
          var paraId = paragraph.ParagraphId;
          if (paraId != null)
            paraIdsCount++;
          var textId = paragraph.TextId;
          if (textId != null)
            textIdsCount++;
          var additionId = paragraph.RsidParagraphAddition;
          if (additionId != null)
            additionIdsCount++;
          var deletionId = paragraph.RsidParagraphDeletion;
          if (deletionId != null)
            deletionIdsCount++;
          var propertiesId = paragraph.RsidParagraphProperties;
          if (propertiesId != null)
            propertiesIdsCount++;
          var runAdditionId = paragraph.RsidRunAdditionDefault;
          if (runAdditionId != null)
            runAdditionIdsCount++;
          var markId = paragraph.RsidParagraphMarkRevision;
          if (markId != null)
            markIdsCount++;
          var noSpellError = paragraph.NoSpellError;
          if (noSpellError != null)
            noSpellErrorsCount++;

          if (verbatim)
            Console.WriteLine($"Paragraph: ID={paraId}, TextID={textId}, AddID={additionId}, DelID={deletionId}, PropsID={propertiesId}, RunAddID={runAdditionId}, MarkID={markId}, NoSpellError={noSpellError}");
          if (paraIds.Contains((HexInt)paraId!))
          {
            Console.WriteLine($"✗ Duplicate paragraph ID found: {paraId}");
          }
          else
          {
            paraIds.Add((HexInt)paraId!);
          }
          paragraphIndex++;
        }
      }
      Console.WriteLine($"Enumerated: {paragraphIndex} paragraphs, {paraIdsCount} parIDs, {textIdsCount} textIDs" +
                        $", {additionIdsCount} addIDs, {deletionIdsCount} delIDs, {propertiesIdsCount} propIDs, {runAdditionIdsCount} runAddIDs, {markIdsCount} markIDs, {noSpellErrorsCount} noSpellErrors");
      if (trial == 0)
      {
        lastParagraphsCount = paragraphIndex;
        lastParagraphIdsCount = paraIdsCount;
        lastTextIdsCount = textIdsCount;
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

    if (lastParagraphIdsCount == 0)
    {
      Console.WriteLine($"✗ Body paragraph IDs count is zero");
      return false;
    }
    if (lastParagraphIdsCount != lastParagraphsCount)
    {
      Console.WriteLine($"✗ Body paragraph IDs count mismatch: {lastParagraphIdsCount} vs {lastParagraphsCount}");
      return false;
    }
    if (lastTextIdsCount == 0)
    {
      Console.WriteLine($"✗ Body text IDs count is zero");
      return false;
    }
    Console.WriteLine($"✓ Enumerate Body Paragraphs with shallow direct access = {directAccess} test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body Paragraph Properties data read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyParagraphPropertiesRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Paragraphs Properties with direct access = {directAccess} ---");

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
    int lastParagraphPropertiesCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int paragraphIndex = 0;
      int paraPropertiesCount = 0;
      List<TimeSpan> paraTimeSpan = new List<TimeSpan>();
      foreach (var item in modelBody.Paragraphs)
      {
        // get shallow data for Paragraph items
        if (item is Paragraph paragraph)
        {
          var paraId = paragraph.ParagraphId;
          var t5 = DateTime.Now;
          var paraProperties = paragraph.ParagraphProperties;
          var t6 = DateTime.Now;
          paraTimeSpan.Add(t6 - t5);
          if (paraProperties != null)
          {
            paraPropertiesCount++;
          }
          if (verbatim)
          {
            Console.WriteLine($"Paragraph[{paragraphIndex}]: ID={paraId}");
            if (paraProperties != null)
            {
              string paraPropertiesString = SerializeObjectToXml(paraProperties!, omitXmlDeclaration: true);
              if (paraPropertiesString != string.Empty)
                Console.WriteLine(paraPropertiesString);
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
      Console.WriteLine($"\nEnumerated: {paragraphIndex} paragraphs, {paraPropertiesCount} Paragraph Properties");
      if (paraTimeSpan.Any())
        Console.WriteLine($" Mean Paragraph Properties read duration: {paraTimeSpan.Average(t => t.TotalMilliseconds)} ms");
      if (trial == 0)
      {
        lastParagraphsCount = paragraphIndex;
        lastParagraphPropertiesCount = paraPropertiesCount;
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

    if (lastParagraphPropertiesCount == 0)
    {
      Console.WriteLine($"✗ Body paragraph Properties count is zero");
      return false;
    }

    Console.WriteLine($"✓ Enumerate Body Paragraphs Properties with direct access = {directAccess} test passed\n");
    return true;
  }


}
