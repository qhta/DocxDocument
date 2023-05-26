namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public static class ChartStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDCS.ChartStyle? GetChartStyle(DXPack.ChartStylePart openXmlElement)
  {
      return DMXDCS.ChartStyleConverter.CreateModelElement(openXmlElement?.RootElement as DXO13DCS.ChartStyle);
  }
  
  private static bool CmpChartStyle(DXPack.ChartStylePart openXmlElement, DMDCS.ChartStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetChartStyle(DXPack.ChartStylePart openXmlElement, DMDCS.ChartStyle? value)
  {
    if (value != null)
    {
       var rootElement = DMXDCS.ChartStyleConverter.CreateOpenXmlElement<DXO13DCS.ChartStyle>(value);
       if (rootElement != null)
         openXmlElement.ChartStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.ChartStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ChartStylePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.ChartStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ChartStylePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ChartStylePart? CreateModelElement(DXPack.ChartStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartStylePart();
      value.ChartStyle = GetChartStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ChartStylePart? openXmlElement, DMPack.ChartStylePart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartStyle(openXmlElement, value.ChartStyle, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartStylePart value)
    where OpenXmlElementType: DXPack.ChartStylePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ChartStylePart openXmlElement, DMPack.ChartStylePart value)
  {
    SetChartStyle(openXmlElement, value?.ChartStyle);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
