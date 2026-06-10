namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="DocumentModel.BuiltInProperties"/>.
/// </summary>
public class BuiltInPropertiesTest : _AbstractModelTestClass<BuiltInProperties>
{

 
  /// <summary>
  /// Updates the specified document with the provided built-in properties.
  /// </summary>
  /// <param name="document">The document to update with new built-in properties.</param>
  /// <param name="data">The built-in properties to apply to the document.</param>
  /// <returns>The updated built-in properties after applying changes to the document.</returns>
  protected override BuiltInProperties UpdateDataInDocument(Document document, BuiltInProperties data)
  {
    TestHelper.UpdateTestData(data);
    return data;
  }

  /// <summary>
  /// Retrieves the XML markup representing the extended file properties from the specified Wordprocessing document.
  /// </summary>
  /// <param name="document">The document from which to extract the extended file properties as XML. Must not be null and must contain a valid
  /// WordprocessingDocument with an ExtendedFilePropertiesPart.</param>
  /// <returns>A string containing the XML markup of the extended file properties for the specified document.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.ExtendedFilePropertiesPart!.Properties!.OuterXml;
  }
}