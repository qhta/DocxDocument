namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="StatisticProperties"/>.
/// </summary>
public class StatisticPropertiesTest : _AbstractModelTestClass<StatisticProperties>
{

  /// <summary>
  /// Updates the specified document with the provided statistical data.
  /// </summary>
  /// <param name="document">The document to update with new statistical data.</param>
  /// <param name="data">The statistical data to apply to the document. This object may be modified during the update process.</param>
  /// <returns>The updated statistical data after applying changes to the document.</returns>
  protected override StatisticProperties UpdateDataInDocument(Document document, StatisticProperties data)
  {
    TestHelper.UpdateTestData(data);
    return data;
  }

  /// <summary>
  /// Retrieves the XML markup representing the extended file properties from the specified WordprocessingML document.
  /// </summary>
  /// <param name="document">The document from which to extract the extended file properties as XML. Must not be null and must contain a valid
  /// WordprocessingDocument with an ExtendedFilePropertiesPart.</param>
  /// <returns>A string containing the XML markup of the extended file properties for the specified document.</returns>
  protected override string? GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument?.ExtendedFilePropertiesPart?.Properties?.OuterXml;
  }
}