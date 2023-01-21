namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public static class CustomXmlPropertiesPartConverter
{
  private static String? GetContentType(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMCustXml.DataStoreItem? GetDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXCustXmlDataProps.DataStoreItem rootElement)
      return DMXCustXml.DataStoreItemConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement, DMCustXml.DataStoreItem? value)
  {
    if (value != null)
    {
       var rootElement = DMXCustXml.DataStoreItemConverter.CreateOpenXmlElement<DXCustXmlDataProps.DataStoreItem>(value);
       if (rootElement != null)
         openXmlElement.DataStoreItem = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.CustomXmlPropertiesPart? CreateModelElement(DXPack.CustomXmlPropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomXmlPropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataStoreItem = GetDataStoreItem(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomXmlPropertiesPart? value)
    where OpenXmlElementType: DXPack.CustomXmlPropertiesPart, new()
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
