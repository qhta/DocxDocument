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
  
  private static bool CmpContentType(DXPack.CustomXmlPropertiesPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMCX.DataStoreItem? GetDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
      return DMXCX.DataStoreItemConverter.CreateModelElement(openXmlElement?.RootElement as DXCXDP.DataStoreItem);
  }
  
  private static bool CmpDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement, DMCX.DataStoreItem? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement, DMCX.DataStoreItem? value)
  {
    if (value != null)
    {
       var rootElement = DMXCX.DataStoreItemConverter.CreateOpenXmlElement<DXCXDP.DataStoreItem>(value);
       if (rootElement != null)
         openXmlElement.DataStoreItem = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.CustomXmlPropertiesPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.CustomXmlPropertiesPart? CreateModelElement(DXPack.CustomXmlPropertiesPart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.CustomXmlPropertiesPart? openXmlElement, DMPack.CustomXmlPropertiesPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpDataStoreItem(openXmlElement, value.DataStoreItem, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomXmlPropertiesPart value)
    where OpenXmlElementType: DXPack.CustomXmlPropertiesPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.CustomXmlPropertiesPart openXmlElement, DMPack.CustomXmlPropertiesPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    SetDataStoreItem(openXmlElement, value?.DataStoreItem);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
