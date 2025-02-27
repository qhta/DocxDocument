namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public static class VbaDataPartConverter
{
  private static String? GetContentType(DXPack.VbaDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.VbaDataPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.VbaDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.VbaDataPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.VbaSuppData? GetVbaSuppData(DXPack.VbaDataPart openXmlElement)
  {
      return DMXW.VbaSuppDataConverter.CreateModelElement(openXmlElement?.RootElement as DXOW.VbaSuppData);
  }
  
  private static bool CmpVbaSuppData(DXPack.VbaDataPart openXmlElement, DMW.VbaSuppData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetVbaSuppData(DXPack.VbaDataPart openXmlElement, DMW.VbaSuppData? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.VbaSuppDataConverter.CreateOpenXmlElement<DXOW.VbaSuppData>(value);
       if (rootElement != null)
         openXmlElement.VbaSuppData = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.VbaDataPart? CreateModelElement(DXPack.VbaDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.VbaDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.VbaSuppData = GetVbaSuppData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.VbaDataPart? openXmlElement, DMPack.VbaDataPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      if (!CmpVbaSuppData(openXmlElement, value.VbaSuppData, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.VbaDataPart value)
    where OpenXmlElementType: DXPack.VbaDataPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.VbaDataPart openXmlElement, DMPack.VbaDataPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetVbaSuppData(openXmlElement, value?.VbaSuppData);
  }
}
