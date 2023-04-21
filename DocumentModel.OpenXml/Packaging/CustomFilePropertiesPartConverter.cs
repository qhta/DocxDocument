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
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMPr.CustomProperties? GetProperties(DXPack.CustomFilePropertiesPart openXmlElement)
  {
      return DMXP.CustomPropertiesConverter.CreateModelElement(openXmlElement?.RootElement as DXCP.Properties);
  }
  
  private static bool CmpProperties(DXPack.CustomFilePropertiesPart openXmlElement, DMPr.CustomProperties? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetProperties(DXPack.CustomFilePropertiesPart openXmlElement, DMPr.CustomProperties? value)
  {
    if (value != null)
    {
       var rootElement = DMXP.CustomPropertiesConverter.CreateOpenXmlElement<DXCP.Properties>(value);
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
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.CustomFilePropertiesPart? CreateModelElement(DXPack.CustomFilePropertiesPart? openXmlElement)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomFilePropertiesPart value)
    where OpenXmlElementType: DXPack.CustomFilePropertiesPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.CustomFilePropertiesPart openXmlElement, DMPack.CustomFilePropertiesPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    SetProperties(openXmlElement, value?.Properties);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
