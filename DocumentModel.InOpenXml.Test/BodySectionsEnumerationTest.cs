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

    if (!TestEnumerateBodySectionsRead(true, true, 2)) return false;
    if (!TestEnumerateBodySectionsRead(false, true, 2)) return false;
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
        DMW.Range range = section.Range;
        if (verbatim)
        {
          Console.WriteLine($"Section {sectionIndex}");
          if (section.Paragraph != null)
            Console.WriteLine($"Paragraph ID: {section.Paragraph.ParagraphId}");
          Console.WriteLine($"Section.Collection={section.Collection}");
          string sectionString = SerializeObjectToXml(section, omitXmlDeclaration: true);
          if (sectionString != string.Empty)
            Console.WriteLine(sectionString);
          Console.WriteLine($"Range: Start={RefStr(range.Start)}, End={RefStr(range.End)}");
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

  private string RefStr(ModelElement element)
  {
    var result = element.GetType().Name;
    if (element is IHexIdentObject hexIdentObject)
    {
      result += $" {hexIdentObject.HexId}";
    }
    return result;
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
