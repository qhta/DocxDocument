namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomFilePropertiesPart
/// </summary>
public static class CustomFilePropertiesPartConverter
{
  private static String? GetContentType(DXPack.CustomFilePropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMProps.CustomProperties? GetProperties(DXPack.CustomFilePropertiesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXCustProps.Properties rootElement)
      return DMXProps.CustomPropertiesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetProperties(DXPack.CustomFilePropertiesPart openXmlElement, DMProps.CustomProperties? value)
  {
    if (value != null)
    {
       var rootElement = DMXProps.CustomPropertiesConverter.CreateOpenXmlElement<DXCustProps.Properties>(value);
       if (rootElement != null)
         openXmlElement.Properties = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.CustomFilePropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.CustomFilePropertiesPart? CreateModelElement(DXPack.CustomFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Properties = GetProperties(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomFilePropertiesPart? value)
    where OpenXmlElementType: DXPack.CustomFilePropertiesPart, new()
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
