namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.CustomProperties.
/// </summary>
public class CustomPropertiesTest: _AbstractModelTestClass<CustomProperties>
{

  /// <summary>
  /// Creates a sample CustomProperties object with various property types.
  /// </summary>
  /// <returns>A populated CustomProperties object.</returns>
  protected override CustomProperties CreateSampleData()
  {
    var props = new CustomProperties();
    props.Add(new CustomProperty
    {
      Name = "CustomString",
      Value = "Test String"
    });
    props.Add(new CustomProperty
    {
      Name = "CustomInt",
      Value = 123
    });
    props.Add(new CustomProperty
    {
      Name = "CustomBool",
      Value = true
    });
    props.Add(new CustomProperty
    {
      Name = "CustomDate",
      Value = DateTime.Parse("2026-01-17T10:00:00Z")
    });

    return props;
  }

  /// <summary>
  /// Retrieves the custom properties from the specified document.
  /// </summary>
  /// <param name="document">The document from which to retrieve custom properties. Cannot be null.</param>
  /// <returns>The collection of custom properties associated with the specified document.</returns>
  protected override CustomProperties GetDataFromDocument(Document document)
  {
    return document.CustomProperties;
  }

  /// <summary>
  /// Sets the custom properties of the specified document to the provided values.
  /// </summary>
  /// <param name="document">The document whose custom properties are to be updated.</param>
  /// <param name="data">The custom properties to assign to the document. Cannot be null.</param>
  /// <returns>The updated collection of custom properties assigned to the document.</returns>
  protected override CustomProperties SetDataToDocument(Document document, CustomProperties data)
  {
    document.CustomProperties = data;
    return document.CustomProperties;
  }

  /// <summary>
  /// Updates the specified document with new custom property data and returns the updated collection of custom
  /// properties.
  /// </summary>
  /// <param name="document">The document to update with the new custom property data. Cannot be null.</param>
  /// <param name="data">The collection of custom properties to add to the document. Cannot be null.</param>
  /// <returns>The updated collection of custom properties from the document after the new data has been added.</returns>
  protected override CustomProperties UpdateDataInDocument(Document document, CustomProperties data)
  {
    data.Add(new CustomProperty { Name = "CustomTitle", Value = "Updated Title" });
    return document.CustomProperties;
  }

  /// <summary>
  /// Retrieves the XML markup of the custom file properties part from the specified Wordprocessing document.
  /// </summary>
  /// <remarks>If the document does not contain a custom file properties part, this method returns an empty
  /// string. The returned XML represents the raw Open XML of the custom properties section, which may be used for
  /// inspection or further processing.</remarks>
  /// <param name="document">The document from which to extract the custom file properties XML. Must not be null.</param>
  /// <returns>A string containing the XML markup of the custom file properties part if present; otherwise, an empty string.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.CustomFilePropertiesPart!.RootElement!.OuterXml;
  }
}