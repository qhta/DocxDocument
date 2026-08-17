using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document sections from a sample file.
/// </summary>
public class BodySectionsEnumerationTest : _AbstractTestClass
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
    //if (!TestEnumerateBodySectionPropertiesRead(true, true, 1)) return false;
    //if (!TestEnumerateBodySectionPropertiesRead(false, false, 2)) return false;

    //if (!TestEnumerateBodySectionsRead(true, true, 1)) return false;
    if (!TestEnumerateBodySectionsRead(false, false, 1)) return false;
    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;

    Console.WriteLine("All Body Sections Enumeration Test passed.\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body Section Properties data read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodySectionPropertiesRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Section Properties with direct access = {directAccess} ---");

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
      //Console.WriteLine($"Get Model items duration: {(t4 - t3).TotalMilliseconds} ms");
      t3 = t4;
      if (verbatim)
        Console.WriteLine("-------------------------------------------------");
    }

    if (lastSectionPropertiesCount == 0)
    {
      Console.WriteLine($"✗ Body Section Properties count is zero");
      return false;
    }

    Console.WriteLine($"✓ Enumerate Body Section Properties with direct access = {directAccess} test passed\n");
    return true;
  }


  /// <summary>
  /// Tests enumerating the document body Sections collection read.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEnumerateBodySectionsRead(bool directAccess, bool verbatim, int times = 1)
  {
    Console.WriteLine($"--- Enumerate Body Sections with direct access = {directAccess} ---");

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
        Console.WriteLine($"Range: Start={RefStr(range.Start)}, End={RefStr(range.End)}, ItemsCount={rangeItemsCount}");
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


    Console.WriteLine($"✓ Enumerate Body Sections with direct access = {directAccess} test passed\n");
    return true;
  }

  private string RefStr(ModelElement element)
  {
    var result = element.GetType().Name;
    if (element is IHexIdentObject hexIdentObject)
    {
      result += $" {hexIdentObject.HexId}";
    }
    return result;
  }



}
