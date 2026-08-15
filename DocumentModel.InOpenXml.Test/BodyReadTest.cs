using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document body from a sample file and serializing created DocumentModel elements.
/// </summary>
public class BodyReadTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Body Count Test ===\n");

    //if (!TestCountBodyItems(true, 2)) return false;
    //if (!TestCountBodyItems(false, 2)) return false;

    //if (!TestCheckBodyEmpty(true, 2)) return false;
    //if (!TestCheckBodyEmpty(false, 2)) return false;

    //if (!TestEnumerateBodyItems(true, false, 2)) return false;
    //if (!TestEnumerateBodyItems(false, false, 2)) return false;

    //if (!TestEnumerateBodyParagraphWithShallowDataRead(true, false, 2)) return false;
    //if (!TestEnumerateBodyParagraphWithShallowDataRead(false, false, 2)) return false;

    //if (!TestEnumerateBodyParagraphPropertiesRead(true, true, 1)) return false;
    //if (!TestEnumerateBodyParagraphPropertiesRead(false, false, 2)) return false;

    //if (!TestEnumerateBodySectionPropertiesRead(true, true, 1)) return false;
    //if (!TestEnumerateBodySectionPropertiesRead(false, false, 2)) return false;

    if (!TestEnumerateBodySectionsRead(true, true, 2)) return false;
    if (!TestEnumerateBodySectionsRead(false, true, 2)) return false;

    Console.WriteLine("All Body read tests passed.\n");
    return true;
  }
  
  /// <summary>
  /// Tests checking document body items count.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestCountBodyItems(bool directAccess, int times = 1)
  {
    Console.WriteLine($"--- Count Body items with direct access = {directAccess} From Sample File ---");

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


    var openXmlCount = openXmlBody.ChildElements.Count;
    var t2 = DateTime.Now;
    Console.WriteLine($"OpenXml body elements count: {openXmlCount}");
    Console.WriteLine($"Get OpenXml body elements count duration: {(t2 - t1).TotalMilliseconds} ms");

    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    modelBody.SetHasDirectAccess(directAccess);
    var t3 = DateTime.Now;
    Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    for (int trial = 0; trial < times; trial++)
    {
      var modelCount = modelBody.Items.Count;
      var t4 = DateTime.Now;
      Console.WriteLine($"Model body elements count: {modelCount}");
      Console.WriteLine($"Get Model items elements count duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (modelCount != openXmlCount)
      {
        Console.WriteLine($"✗ Body items count mismatch: model={modelCount}, openXml={openXmlCount}");
        return false;
      }
    }

    Console.WriteLine($"✓ Count Body items with direct access = {directAccess} from sample file test passed\n");
    return true;
  }

  /// <summary>
  /// Tests checking if the document body is empty.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestCheckBodyEmpty(bool directAccess, int times = 1)
  {
    Console.WriteLine($"--- Check if Body is empty with direct access = {directAccess} From Sample File ---");

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


    var openXmlIsEmpty = !openXmlBody.ChildElements.Any();
    var t2 = DateTime.Now;
    Console.WriteLine($"OpenXml body is empty: {openXmlIsEmpty}");
    Console.WriteLine($"Check OpenXml body elements is empty duration: {(t2 - t1).TotalMilliseconds} ms");

    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    modelBody.SetHasDirectAccess(directAccess);
    var t3 = DateTime.Now;
    Console.WriteLine($"LoadData duration: {(t3 - t2).TotalMilliseconds} ms");
    for (int trial = 0; trial < times; trial++)
    {
      var modelCountIsEmpty = modelBody.Items.IsEmpty();
      var t4 = DateTime.Now;
      Console.WriteLine($"Model body is empty: {modelCountIsEmpty}");
      Console.WriteLine($"Get Model items is empty duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (modelCountIsEmpty != openXmlIsEmpty)
      {
        Console.WriteLine($"✗ Body items count mismatch: model={modelCountIsEmpty}, openXml={openXmlIsEmpty}");
        return false;
      }
    }

    Console.WriteLine($"✓ Check if Body is empty with direct access = {directAccess} from sample file test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body items (shallow enumeration).
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyItems(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body items with direct access = {directAccess} From Sample File ---");

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
      if (trial==0)
        lastItemsCount = itemIndex;
      else if (itemIndex != lastItemsCount)
      {
        Console.WriteLine($"✗ Body items count mismatch between iterations: {lastItemsCount} vs {itemIndex}");
        return false;
      }
      var t4 = DateTime.Now;
      Console.WriteLine($"Get Model items duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
    }

    if (lastItemsCount==0)
    {
      Console.WriteLine($"✗ Body items count is zero");
      return false;
    } 
    Console.WriteLine($"✓ Enumerate Body items with direct access = {directAccess} from sample file test passed\n");
    return true;
  }

  /// <summary>
  /// Tests enumerating the document body Paragraph items with shallow data read (without loading full data for each Paragraph).
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyParagraphWithShallowDataRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Paragraphs with shallow direct access = {directAccess} From Sample File ---");

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
          if (paraId!=null)
            paraIdsCount++;
          var textId = paragraph.TextId;
          if (textId!=null)
            textIdsCount++;
          var additionId = paragraph.RsidParagraphAddition;
          if (additionId!=null)
            additionIdsCount++;
          var deletionId = paragraph.RsidParagraphDeletion;
          if (deletionId!=null)
            deletionIdsCount++;
          var propertiesId = paragraph.RsidParagraphProperties;
          if (propertiesId!=null)
            propertiesIdsCount++;
          var runAdditionId = paragraph.RsidRunAdditionDefault;
          if (runAdditionId!=null)
            runAdditionIdsCount++;
          var markId = paragraph.RsidParagraphMarkRevision;
          if (markId!=null)
            markIdsCount++;
          var noSpellError = paragraph.NoSpellError;
          if (noSpellError!=null)
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
    Console.WriteLine($"✓ Enumerate Body Paragraphs with shallow direct access = {directAccess} from sample file test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body Paragraph Properties data read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodyParagraphPropertiesRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Paragraphs Properties with direct access = {directAccess} From Sample File ---");

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
          if (paragraphIndex==2)
            break; // limit to first 2 paragraphs for performance
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

    Console.WriteLine($"✓ Enumerate Body Paragraphs Properties with direct access = {directAccess} from sample file test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body Section Properties data read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodySectionPropertiesRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Section Properties with direct access = {directAccess} From Sample File ---");

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
    int lastSectionPropertiesCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int paragraphIndex = 0;
      int sectPropertiesCount = 0;
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
          if (paraProperties?.SectionProperties != null)
          {
            sectPropertiesCount++;

            if (verbatim)
            {
              Console.WriteLine($"Paragraph[{paragraphIndex}]: ID={paraId}");
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
      }
      Console.WriteLine($"\nEnumerated: {sectPropertiesCount} Section Properties");
      if (paraTimeSpan.Any())
        Console.WriteLine($" Mean Section Properties read duration: {paraTimeSpan.Average(t => t.TotalMilliseconds)} ms");
      if (trial == 0)
      {
        lastParagraphsCount = paragraphIndex;
        lastSectionPropertiesCount = sectPropertiesCount;
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

    if (lastSectionPropertiesCount == 0)
    {
      Console.WriteLine($"✗ Body Section Properties count is zero");
      return false;
    }

    Console.WriteLine($"✓ Enumerate Body Section Properties with direct access = {directAccess} from sample file test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body Sections collection read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodySectionsRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Sections with direct access = {directAccess} From Sample File ---");

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
    int lastSectionsCount = 0;
    for (int trial = 0; trial < times; trial++)
    {
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
      int sectionIndex = 0;
      int sectionsCount = 0;
      foreach (var section in modelBody.Sections)
      {

        //var paraId = paragraph.ParagraphId;
        //var t5 = DateTime.Now;
        //var paraProperties = paragraph.ParagraphProperties;
        //var t6 = DateTime.Now;
        //paraTimeSpan.Add(t6 - t5);
        //if (paraProperties?.SectionProperties != null)
        //{
        //  sectPropertiesCount++;

          if (verbatim)
          {
            Console.WriteLine($"Section {sectionIndex}");
            string sectionString = SerializeObjectToXml(section, omitXmlDeclaration: true);
            if (sectionString != string.Empty)
              Console.WriteLine(sectionString);
          }
          else
          {
            Console.Write(".");
          }
          sectionIndex++;
          sectionsCount++;

      }
      Console.WriteLine($"\nEnumerated: {sectionsCount} Sections");
      if (trial == 0)
      {
        lastSectionsCount = sectionsCount;
      }

      var t4 = DateTime.Now;
      Console.WriteLine($"Get Model items duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
    }

    if (lastSectionsCount == 0)
    {
      Console.WriteLine($"✗ Body Sections count is zero");
      return false;
    }

    Console.WriteLine($"✓ Enumerate Body Sections with direct access = {directAccess} from sample file test passed\n");
    return true;
  }

  ///// <summary>
  ///// Tests reading document body from the sample file and loading it into DocumentModel body.
  ///// </summary>
  ///// <returns>True if the test passes; otherwise, false.</returns>
  //private bool TestReadBodyAndSerialize(bool directAccess, int times = 1)
  //{
  //  Console.WriteLine("--- Read Body From Sample File ---");

  //  if (!File.Exists(SampleFilePath))
  //  {
  //    Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
  //    return false;
  //  }

  //  using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
  //  var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
  //  if (openXmlBody == null)
  //  {
  //    Console.WriteLine("✗ OpenXml body not found");
  //    return false;
  //  }

  //  var t0 = DateTime.Now;
  //  Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
  //  modelBody.SetHasDirectAccess(directAccess);
  //  var t1 = DateTime.Now;
  //  Console.WriteLine($"LoadData duration: {(t1 - t0).TotalMilliseconds} ms");
  //  var openXmlCount = openXmlBody.ChildElements.Count;
  //  var modelCount = modelBody.Items.Count;
  //  var t2 = DateTime.Now;
  //  Console.WriteLine($"Count retrieval duration: {(t2 - t1).TotalMilliseconds} ms");
  //  Console.WriteLine($"OpenXml body elements count: {openXmlCount}");
  //  Console.WriteLine($"Model body elements count: {modelCount}");

  //  if (modelCount == 0)
  //  {
  //    Console.WriteLine("✗ Model body is empty after load");
  //    return false;
  //  }

  //  if (modelCount != openXmlCount)
  //  {
  //    Console.WriteLine($"✗ Body element count mismatch: model={modelCount}, openXml={openXmlCount}");
  //    return false;
  //  }
  //  var t3 = DateTime.Now;
  //  var bodyXml = SerializeObjectToXml(modelBody);
  //  var t4 = DateTime.Now;
  //  Debug.WriteLine($"Serialization duration: {(t4 - t3).TotalMilliseconds} ms");
  //  Console.WriteLine("Serialized Body XML:\n" + bodyXml);

  //  Console.WriteLine("✓ Body read from sample file test passed\n");
  //  return true;
  //}


}
