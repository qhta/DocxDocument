using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Properties;
using DocumentModel.Properties;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the ExtendedFilePropertiesPart
/// </summary>
public static class ExtendedFilePropertiesPartConverter
{
  public static String? GetContentType(ExtendedFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static ExtendedProperties? GetProperties(ExtendedFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.ExtendedProperties.Properties rootElement)
      return ExtendedPropertiesConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetProperties(ExtendedFilePropertiesPart? openXmlElement, ExtendedProperties? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ExtendedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.ExtendedProperties.Properties>(value);
        if (rootElement != null)
          openXmlElement.Properties = rootElement;
      }
  }

  public static String? GetRelationshipType(ExtendedFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.ExtendedFilePropertiesPart? CreateModelElement(ExtendedFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ExtendedFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Properties = GetProperties(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ExtendedFilePropertiesPart? value)
    where OpenXmlElementType : ExtendedFilePropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetProperties(openXmlElement, value?.Properties);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}