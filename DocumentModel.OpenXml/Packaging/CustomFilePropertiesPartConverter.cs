using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Properties;
using DocumentModel.Properties;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the CustomFilePropertiesPart
/// </summary>
public static class CustomFilePropertiesPartConverter
{
  public static String? GetContentType(CustomFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static CustomProperties? GetProperties(CustomFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.CustomProperties.Properties rootElement)
      return CustomPropertiesConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetProperties(CustomFilePropertiesPart? openXmlElement, CustomProperties? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = CustomPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomProperties.Properties>(value);
        if (rootElement != null)
          openXmlElement.Properties = rootElement;
      }
  }

  public static String? GetRelationshipType(CustomFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.CustomFilePropertiesPart? CreateModelElement(CustomFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Properties = GetProperties(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomFilePropertiesPart? value)
    where OpenXmlElementType : CustomFilePropertiesPart, new()
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