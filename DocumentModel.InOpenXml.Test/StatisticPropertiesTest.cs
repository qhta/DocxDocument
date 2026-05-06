namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="StatisticProperties"/>.
/// </summary>
public class StatisticPropertiesTest : _AbstractModelTestClass<StatisticProperties>
{

  /// <summary>
  /// Creates a sample <see cref="StatisticProperties"/> instance for testing.
  /// </summary>
  /// <returns>A populated <see cref="StatisticProperties"/> object.</returns>
  protected override StatisticProperties CreateSampleData()
  {
    return new StatisticProperties
    {
      Pages = 10,
      Words = 2500,
      Characters = 15000,
      Lines = 200,
      Paragraphs = 50,
      CharactersWithSpaces = 17000,
      Slides = 5,
      Notes = 2,
      HiddenSlides = 1,
      MultimediaClips = 3,
      TotalTime = 123
    };
  }

  /// <summary>
  /// Retrieves the <see cref="StatisticProperties"/> from the given <see cref="Document"/> for testing.
  /// </summary>
  /// <param name="document">The document from which to retrieve the statistic properties.</param>
  /// <returns></returns>
  protected override StatisticProperties GetDataFromDocument(Document document)
  {
    return document.StatisticProperties;
  }

  /// <summary>
  /// Sets the specified statistic properties on the given document and returns the updated properties.
  /// </summary>
  /// <param name="document">The document to which the statistic properties will be assigned. Cannot be null.</param>
  /// <param name="data">The statistic properties to set on the document. Cannot be null.</param>
  /// <returns>The updated statistic properties assigned to the document.</returns>
  protected override StatisticProperties SetDataToDocument(Document document, StatisticProperties data)
  {
    document.StatisticProperties = data;
    return document.StatisticProperties;
  }

  /// <summary>
  /// Updates the specified document with the provided statistical data.
  /// </summary>
  /// <param name="document">The document to update with new statistical data.</param>
  /// <param name="data">The statistical data to apply to the document. This object may be modified during the update process.</param>
  /// <returns>The updated statistical data after applying changes to the document.</returns>
  protected override StatisticProperties UpdateDataInDocument(Document document, StatisticProperties data)
  {
    TestHelper.ChangeTestData(data);
    return data;
  }

  /// <summary>
  /// Retrieves the XML markup representing the extended file properties from the specified WordprocessingML document.
  /// </summary>
  /// <param name="document">The document from which to extract the extended file properties as XML. Must not be null and must contain a valid
  /// WordprocessingDocument with an ExtendedFilePropertiesPart.</param>
  /// <returns>A string containing the XML markup of the extended file properties for the specified document.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.ExtendedFilePropertiesPart!.Properties!.OuterXml;
  }
}