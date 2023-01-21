namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ExtendedFilePropertiesPart
/// </summary>
public static class ExtendedFilePropertiesPartConverter
{
  private static String? GetContentType(DXPack.ExtendedFilePropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMProps.ExtendedProperties? GetProperties(DXPack.ExtendedFilePropertiesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXExtProps.Properties rootElement)
      return DMXProps.ExtendedPropertiesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetProperties(DXPack.ExtendedFilePropertiesPart openXmlElement, DMProps.ExtendedProperties? value)
  {
    if (value != null)
    {
       var rootElement = DMXProps.ExtendedPropertiesConverter.CreateOpenXmlElement<DXExtProps.Properties>(value);
       if (rootElement != null)
         openXmlElement.Properties = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.ExtendedFilePropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.ExtendedFilePropertiesPart? CreateModelElement(DXPack.ExtendedFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ExtendedFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Properties = GetProperties(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ExtendedFilePropertiesPart? value)
    where OpenXmlElementType: DXPack.ExtendedFilePropertiesPart, new()
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
