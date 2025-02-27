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
  
  private static bool CmpContentType(DXPack.ExtendedFilePropertiesPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMProps.ExtendedProperties? GetProperties(DXPack.ExtendedFilePropertiesPart openXmlElement)
  {
      return DMXProps.ExtendedPropertiesConverter.CreateModelElement(openXmlElement?.RootElement as DXExtProps.Properties);
  }
  
  private static bool CmpProperties(DXPack.ExtendedFilePropertiesPart openXmlElement, DMProps.ExtendedProperties? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpRelationshipType(DXPack.ExtendedFilePropertiesPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ExtendedFilePropertiesPart? CreateModelElement(DXPack.ExtendedFilePropertiesPart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.ExtendedFilePropertiesPart? openXmlElement, DMPack.ExtendedFilePropertiesPart? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ExtendedFilePropertiesPart value)
    where OpenXmlElementType: DXPack.ExtendedFilePropertiesPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ExtendedFilePropertiesPart openXmlElement, DMPack.ExtendedFilePropertiesPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    SetProperties(openXmlElement, value?.Properties);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
