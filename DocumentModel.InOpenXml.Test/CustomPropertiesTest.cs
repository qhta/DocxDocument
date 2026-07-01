using DocumentModel.Properties;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.CustomProperties.
/// </summary>
public class CustomPropertiesTest : _AbstractModelTestClass<CustomProperties>
{

  /// <summary>
  /// Creates a sample CustomProperties object with various property types.
  /// </summary>
  /// <returns>A populated CustomProperties object.</returns>
  protected override CustomProperties CreateSampleData()
    => CreateCustomProperties();


  /// <summary>
  /// Creates a sample CustomProperties object with various property types.
  /// </summary>
  /// <returns>A populated CustomProperties object.</returns>
  public static CustomProperties CreateCustomProperties()
  {
    var props = new CustomProperties
    {
      new CustomProperty
      {
        Name = "CustomString",
        Value = "Test String"
      },
      new CustomProperty
      {
        Name = "CustomInt",
        Value = 123
      },
      new CustomProperty
      {
        Name = "CustomBool",
        Value = true
      },
      new CustomProperty
      {
        Name = "CustomDate",
        Value = DateTime.Now,
      },
      new CustomProperty
      {
        Name = "CustomFloat",
        Value = 123.45f,
      },
      new CustomProperty
      {
        Name = "EmptyPropertyWithLink",
        LinkTarget = "SomeLinkTarget"
      },
      new CustomProperty
      {
        Name = "EmptyPropertyWithExpectedType",
        ExpectedType = DocumentPropertyType.Float
      },
    };
    return props;
  }

  /// <summary>
  /// Updates the specified document with new custom property data and returns the updated collection of custom property data.
  /// </summary>
  /// <param name="document">The document to update with the new custom property data. Cannot be null.</param>
  /// <param name="data">The collection of custom properties to add to the document. Cannot be null.</param>
  /// <returns>The updated collection of custom properties from the document after the new data has been added.</returns>
  protected override CustomProperties UpdateDataInDocument(Document document, CustomProperties data)
    => UpdateCustomProperties(document, data);

  /// <summary>
  /// Updates the specified document with new custom property data and returns the updated collection of custom
  /// properties.
  /// </summary>
  /// <param name="document">The document to update with the new custom property data. Cannot be null.</param>
  /// <param name="data">The collection of custom properties to add to the document. Cannot be null.</param>
  /// <returns>The updated collection of custom properties from the document after the new data has been added.</returns>
  public static CustomProperties UpdateCustomProperties(Document document, CustomProperties data)
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


  /// <summary>
  /// Retrieves the custom properties from the specified document.
  /// </summary>
  /// <param name="document">The document from which to retrieve the custom properties. Must not be null.</param>
  /// <returns>The collection of custom properties from the document.</returns>
  protected override CustomProperties GetDataFromDocument(Document document)
  {
    var result = base.GetDataFromDocument(document);
    return result;
  }

  /// <summary>
  /// Compares two instances of the specified type for equality, providing detailed information about any differences found.
  /// </summary>
  /// <typeparam name="T">The type of the objects to compare.</typeparam>
  /// <param name="obj1">The first object to compare.</param>
  /// <param name="obj2">The second object to compare.</param>
  /// <param name="firstName">The name of the first object, used in the comparison message.</param>
  /// <param name="secondName">The name of the second object, used in the comparison message.</param>
  /// <param name="message">The message describing the differences found, if any.</param>
  /// <returns>True if the objects are equal; otherwise, false.</returns>
  protected override bool CompareTestData<T>(T obj1, T obj2, string firstName, string secondName, out string? message)
  {
    var result = base.CompareTestData(obj1, obj2, firstName, secondName, out message);
    return result;
  }
}