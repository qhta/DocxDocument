namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public static class ChartColorStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDCS.ColorStyle? GetColorStyle(DXPack.ChartColorStylePart openXmlElement)
  {
      return DMXDCS.ColorStyleConverter.CreateModelElement(openXmlElement?.RootElement as DXO13DCS.ColorStyle);
  }
  
  private static bool CmpColorStyle(DXPack.ChartColorStylePart openXmlElement, DMDCS.ColorStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetColorStyle(DXPack.ChartColorStylePart openXmlElement, DMDCS.ColorStyle? value)
  {
    if (value != null)
    {
       var rootElement = DMXDCS.ColorStyleConverter.CreateOpenXmlElement<DXO13DCS.ColorStyle>(value);
       if (rootElement != null)
         openXmlElement.ColorStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ChartColorStylePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ChartColorStylePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ChartColorStylePart? CreateModelElement(DXPack.ChartColorStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartColorStylePart();
      value.ColorStyle = GetColorStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ChartColorStylePart? openXmlElement, DMPack.ChartColorStylePart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorStyle(openXmlElement, value.ColorStyle, diffs, objName, propName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartColorStylePart value)
    where OpenXmlElementType: DXPack.ChartColorStylePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ChartColorStylePart openXmlElement, DMPack.ChartColorStylePart value)
  {
    SetColorStyle(openXmlElement, value?.ColorStyle);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
