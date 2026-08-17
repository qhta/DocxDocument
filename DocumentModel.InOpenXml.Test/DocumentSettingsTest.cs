namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Provides comprehensive serialization tests for <see cref="DocumentSettings"/>.
  /// </summary>
  public class DocumentSettingsTest: _AbstractModelTestClass<DocumentSettings>
  {

    /// <summary>
    /// Creates a new instance of <see cref="DocumentSettings"/> populated with sample test data.
    /// </summary>
    /// <returns>A <see cref="DocumentSettings"/> instance with sample data.</returns>
    protected override DocumentSettings CreateSampleData()
    {
      var result = new DocumentSettings();
      TestHelper.PopulateTestData(result);
      return result;
    }

    /// <summary>
    /// Updates the provided <see cref="DocumentSettings"/> instance with new test data and adds a compatibility setting.
    /// </summary>
    /// <param name="document">The document in which to update the settings.</param>
    /// <param name="data">The document settings to update.</param>
    /// <returns>The updated document settings.</returns>
    protected override DocumentSettings UpdateDataInDocument(Document document, DocumentSettings data)
    {
      TestHelper.UpdateTestData(data);
      data.Add(new CompatibilitySetting { Name = "CompatibilityMode", Val = "value" });
      return data;
    }

    /// <summary>
    /// Retrieves the XML representation of the document settings from the specified WordprocessingML document.
    /// </summary>
    /// <remarks>The returned XML represents the settings part of the WordprocessingML document, which may
    /// include configuration such as compatibility options, protection settings, and other document-level properties.
    /// Ensure that the document contains a settings part; otherwise, a NullReferenceException may occur.</remarks>
    /// <param name="document">The document from which to extract the settings as Open XML. Must contain a valid WordprocessingDocument with
    /// settings part present.</param>
    /// <returns>A string containing the outer XML of the document settings part.</returns>
    protected override string GetOpenXmlFromDocument(Document document)
    {
      return document.WordprocessingDocument!.GetDocumentSettings()!.OuterXml;
    }
  }
}