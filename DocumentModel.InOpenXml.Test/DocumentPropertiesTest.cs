using System.Xml.Linq;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="DocumentModel.DocumentProperties"/>.
/// </summary>
public class DocumentPropertiesTest : _AbstractModelTestClass<DocumentProperties>
{


  /// <summary>
  /// Runs all tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine($"=== {TestName} test ===\n");
    var t0 = DateTime.Now;
    if (!TestJsonSerialization()) return false;
    var t1 = DateTime.Now;
    TotalJsonSerialization += (t1 - t0).TotalMilliseconds;
    if (!TestXmlSerialization()) return false;
    var t2 = DateTime.Now;
    TotalXmlSerialization += (t2 - t1).TotalMilliseconds;
    //if (!TestEdgeCases()) return false;
    //if (!TestStoreDataInOpenXmlDocument()) return false;
    //if (!TestUpdateDataInOpenXmlDocument()) return false;
    //if (!TestStoreDataInXmlDocument()) return false;
    Console.WriteLine($"All {TestName} tests passed.\n");
    return true;
  }

  /// <summary>
  /// Creates a new instance of <see cref="DocumentProperties"/> populated with sample data for testing purposes.
  /// </summary>
  /// <returns></returns>
  protected override DocumentProperties CreateSampleData()
  {
    var DocumentProperties = new DocumentProperties();
    TestHelper.PopulateTestData(DocumentProperties.BuiltInProperties);
    TestHelper.PopulateTestData(DocumentProperties.CustomProperties);
    return DocumentProperties;
  }

  /// <summary>
  /// Updates the specified document with the provided built-in properties.
  /// </summary>
  /// <param name="document">The document to update with new built-in properties.</param>
  /// <param name="data">The built-in properties to apply to the document.</param>
  /// <returns>The updated built-in properties after applying changes to the document.</returns>
  protected override DocumentProperties UpdateDataInDocument(Document document, DocumentProperties data)
  {
    TestHelper.UpdateTestData(data.BuiltInProperties);
    TestHelper.UpdateTestData(data.CustomProperties);
    return data;
  }

  /// <summary>
  /// Sets the built-in properties of the specified document to the provided data and returns the updated built-in properties from the document.  
  /// </summary>
  /// <param name="document">The document to update with new built-in properties.</param>
  /// <param name="data">The built-in properties to apply to the document.</param>
  /// <returns>The updated built-in properties after applying changes to the document.</returns>
  protected override DocumentProperties SetDataToDocument(Document document, DocumentProperties data)
  {
    document.DocumentProperties = data;
    return document.DocumentProperties;
  }

  /// <summary>
  /// Retrieves the built-in properties from the specified document for comparison with expected data.
  /// </summary>
  /// <param name="document">The document from which to retrieve the built-in properties.</param>
  /// <returns>The built-in properties of the specified document.</returns>
  protected override DocumentProperties GetDataFromDocument(Document document)
  {
    return document.DocumentProperties;
  }

  /// <summary>
  /// Retrieves the XML markup representing the extended file properties from the specified Wordprocessing document.
  /// </summary>
  /// <param name="document">The document from which to extract the extended file properties as XML. Must not be null and must contain a valid
  /// WordprocessingDocument with an ExtendedFilePropertiesPart.</param>
  /// <returns>A string containing the XML markup of the extended file properties for the specified document.</returns>
  protected override string? GetOpenXmlFromDocument(Document document)
  {
    var result = new List<string>();
    var corePart = document.WordprocessingDocument?.CoreFilePropertiesPart;
    if (corePart != null)
    {
      using (var stream = corePart.GetStream())
      using (var reader = new StreamReader(stream))
        result.Add(reader.ReadToEnd());
    }
    var extendedProperties = document.WordprocessingDocument?.ExtendedFilePropertiesPart?.Properties?.OuterXml;
    if (extendedProperties != null)
      result.Add(extendedProperties);

    var rootElement = new XElement("DocumentProperties", result.Select(XElement.Parse));
    var xDocument = new XDocument(rootElement);
    return xDocument.ToString();
  }
}