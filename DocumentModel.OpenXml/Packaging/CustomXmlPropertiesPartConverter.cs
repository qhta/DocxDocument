namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPar converter from/to OpenXml.
///</summary>
public static class CustomXmlPropertiesPartConverter
{
  private static String? GetContentType(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.CustomXmlPropertiesPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMCustXml.DataStoreItem? GetDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement)
  {
      return DMXCustXml.DataStoreItemConverter.CreateModelElement(openXmlElement?.RootElement as DXCustXmlDataProps.DataStoreItem);
  }
  
  private static bool CmpDataStoreItem(DXPack.CustomXmlPropertiesPart openXmlElement, DMCustXml.DataStoreItem? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpRelationshipType(DXPack.CustomXmlPropertiesPart openXmlElement, String? value, DiffList? diffs, string? objName)
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
  
  public static bool CompareModelElement(DXPack.CustomXmlPropertiesPart? openXmlElement, DMPack.CustomXmlPropertiesPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpDataStoreItem(openXmlElement, value.DataStoreItem, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
