namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public static class CustomXmlPropertiesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.CustomXml.DataStoreItem? GetDataStoreItem(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetDataStoreItem(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? openXmlElement, DocumentModel.CustomXml.DataStoreItem? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.CustomXmlPropertiesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataStoreItem(openXmlElement, value?.DataStoreItem);
      return openXmlElement;
    }
    return default;
  }
}
