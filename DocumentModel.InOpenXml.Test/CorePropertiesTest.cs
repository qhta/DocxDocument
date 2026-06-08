using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.CoreProperties.
/// </summary>
public class CorePropertiesTest: _AbstractModelTestClass<CoreProperties>
{

  /// <summary>
  /// Updates the specified document with the provided core properties data.
  /// </summary>
  /// <param name="document">The document to update with new data.</param>
  /// <param name="data">The core properties data to apply to the document.</param>
  /// <returns>The updated core properties data after applying changes to the document.</returns>
  protected override CoreProperties UpdateDataInDocument(Document document, CoreProperties data)
  {
    TestHelper.UpdateTestData(data);
    return data;

  }

  /// <summary>
  /// Retrieves the XML markup of the core file properties part from the specified WordprocessingML document.
  /// </summary>
  /// <remarks>The returned XML represents the metadata properties of the WordprocessingML document, such as
  /// title, author, and subject. This method assumes that the document contains a CoreFilePropertiesPart; otherwise, a
  /// NullReferenceException may occur.</remarks>
  /// <param name="document">The document from which to extract the core file properties XML. Must not be null and must contain a valid
  /// WordprocessingDocument with a CoreFilePropertiesPart.</param>
  /// <returns>A string containing the outer XML of the core file properties part of the document.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    var corePart = document.WordprocessingDocument!.CoreFilePropertiesPart!;
    using (var stream = corePart.GetStream())
      using (var reader = new StreamReader(stream))
        return reader.ReadToEnd();
  }
}