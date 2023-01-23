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
  
  private static bool CmpContentType(DXPack.CustomFilePropertiesPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMProps.CustomProperties? GetProperties(DXPack.CustomFilePropertiesPart openXmlElement)
  {
      return DMXProps.CustomPropertiesConverter.CreateModelElement(openXmlElement?.RootElement as DXCustProps.Properties);
  }
  
  private static bool CmpProperties(DXPack.CustomFilePropertiesPart openXmlElement, DMProps.CustomProperties? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpRelationshipType(DXPack.CustomFilePropertiesPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  public static bool CompareModelElement(DXPack.CustomFilePropertiesPart? openXmlElement, DMPack.CustomFilePropertiesPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpProperties(openXmlElement, value.Properties, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
