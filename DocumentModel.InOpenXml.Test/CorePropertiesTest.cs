using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.CoreProperties.
/// </summary>
public class CorePropertiesTest: _AbstractModelTestClass<CoreProperties>
{
  /// <summary>
  /// Creates a new instance of the CoreProperties class populated with sample metadata values for testing or
  /// demonstration purposes.
  /// </summary>
  /// <remarks>The returned CoreProperties instance contains preset values suitable for use in serialization
  /// tests or as a template for document property configuration. The associated document is created in a temporary
  /// file and disposed after the properties are initialized.</remarks>
  /// <returns>A CoreProperties object initialized with example document metadata such as title, subject, creator, and other
  /// properties.</returns>
  protected override CoreProperties CreateSampleData()
  {
    var props = new CoreProperties()
    {
      Title = "Sample Title",
      Subject = "Sample Subject",
      Creator = "Test Creator",
      Keywords = "test,serialization,core",
      Description = "A test description for serialization.",
      LastModifiedBy = "TestUser",
      Revision = 5,
      LastPrinted = new DateTime(2024, 1, 1, 12, 0, 0),
      Created = new DateTime(2023, 12, 31, 23, 59, 59),
      Modified = new DateTime(2024, 1, 2, 8, 30, 0),
      Category = "TestCategory",
      Identifier = "ID-12345",
      ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
      Language = "en-US",
      Version = "1.0",
      ContentStatus = "Draft"
    };
    return props;
  }

  /// <summary>
  /// Retrieves the CoreProperties data from the provided Document instance for testing purposes.
  /// </summary>
  /// <param name="document">The Document instance from which to retrieve the CoreProperties.</param>
  /// <returns></returns>
  protected override CoreProperties GetDataFromDocument(Document document)
  {
    return document.CoreProperties;
  }

  /// <summary>
  /// Sets the specified core properties on the given document and returns the updated core properties.
  /// </summary>
  /// <param name="document">The document to which the core properties will be applied. Cannot be null.</param>
  /// <param name="data">The core properties to set on the document. Cannot be null.</param>
  /// <returns>The updated core properties of the document after the assignment.</returns>
  protected override CoreProperties SetDataToDocument(Document document, CoreProperties data)
  {
    document.CoreProperties = data;
    return document.CoreProperties;
  }

  /// <summary>
  /// Updates the specified document with the provided core properties data.
  /// </summary>
  /// <param name="document">The document to update with new data.</param>
  /// <param name="data">The core properties data to apply to the document.</param>
  /// <returns>The updated core properties data after applying changes to the document.</returns>
  protected override CoreProperties UpdateDataInDocument(Document document, CoreProperties data)
  {
    TestHelper.ChangeTestData(data);
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