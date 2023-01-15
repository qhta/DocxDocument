using DocumentFormat.OpenXml.Packaging;
using DocumentModel.CustomXml;
using DocumentModel.OpenXml.CustomXml;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the CustomXmlPropertiesPart
/// </summary>
public static class CustomXmlPropertiesPartConverter
{
  public static String? GetContentType(CustomXmlPropertiesPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static DataStoreItem? GetDataStoreItem(CustomXmlPropertiesPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem rootElement)
      return DataStoreItemConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetDataStoreItem(CustomXmlPropertiesPart? openXmlElement, DataStoreItem? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = DataStoreItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem>(value);
        if (rootElement != null)
          openXmlElement.DataStoreItem = rootElement;
      }
  }

  public static String? GetRelationshipType(CustomXmlPropertiesPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.CustomXmlPropertiesPart? CreateModelElement(CustomXmlPropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomXmlPropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataStoreItem = GetDataStoreItem(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomXmlPropertiesPart? value)
    where OpenXmlElementType : CustomXmlPropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetDataStoreItem(openXmlElement, value?.DataStoreItem);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}