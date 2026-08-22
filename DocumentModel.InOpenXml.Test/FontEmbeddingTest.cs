namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Test of font embedding functionality in DocumentModel, including reading and serializing the font table from a Word document.
/// </summary>
public class FontEmbeddingTestClass: _AbstractTestClass
{
  /// <summary>
  /// Executes the test including EmbedFont tests, 
  /// </summary>
  /// <returns></returns>
  public override bool Run()
  {
    Console.WriteLine($"=== {TestName} test ===\n");
    var t0 = DateTime.Now;
    if (!TestEmbedFontsFull()) return false;
    var t1 = DateTime.Now;
    TotalLoadFromOpenXml += (t1 - t0).TotalMilliseconds;
    Console.WriteLine($"All {TestName} tests passed.\n");
    return true;
  }

  private bool TestEmbedFontsFull()
  {

    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    var testFileName = Path.Combine(TestFileDir, $"Font embedding full.docx");

    using (var document = Document.Open(testFileName, FileMode.OpenOrCreate, FileAccess.Read))
    {
      var openXml = GetOpenXmlFromDocument(document);
      if (openXml != null)
      {
        var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
        Console.WriteLine(formattedOpenXml);
      }
      FontTable testData = document.FontTable;
      var xmlSerializer = XmlSerializationHelper.CreateXmlSerializer(testData);
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData, XmlSerializationHelper.Namespaces);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine($"{TestName} Serialized XML:\n" + xmlString);
      var timesNewRomanFont = testData.FirstOrDefault(f => f.Typeface == "Times New Roman");
      if (timesNewRomanFont == null)
      {
        Console.WriteLine($"✗ {TestName} {testMethodName} failed: 'Times New Roman' font not found in font table.");
        return false;
      }
      if (timesNewRomanFont.EmbedRegularFont==null)
      {
        Console.WriteLine($"✗ {TestName} {testMethodName} failed: 'Times New Roman' font does not have an embedded regular font.");
        return false;
      }
      if (timesNewRomanFont.EmbedRegularFont.FontData == null)
      {
        Console.WriteLine($"✗ {TestName} {testMethodName} failed: 'Times New Roman' font does not have font data for the embedded regular font.");
        return false;
      }
      var fontFileName = Path.Combine(TestFileDir, $"Times.ttf");

      var fontData = (byte[])timesNewRomanFont.EmbedRegularFont.FontData;
      using (var memStream = new MemoryStream(fontData)) 
        using (var stream = new FileStream(fontFileName, FileMode.Create, FileAccess.Write))
        {
          memStream.CopyTo(stream);
        }
    }
    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Gets the OpenXml representation of the font table from the specified document.
  /// </summary>
  /// <param name="document">The document from which to retrieve the OpenXml representation.</param>
  /// <returns>The OpenXml representation of the font table.</returns>
  protected string? GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument?.MainDocumentPart?.FontTablePart?.Fonts?.OuterXml;
  }
}