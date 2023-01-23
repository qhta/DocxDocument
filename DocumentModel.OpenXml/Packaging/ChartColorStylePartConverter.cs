namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public static class ChartColorStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsChartsStyle.ColorStyle? GetColorStyle(DXPack.ChartColorStylePart openXmlElement)
  {
      return DMXDrawsChartsStyle.ColorStyleConverter.CreateModelElement(openXmlElement?.RootElement as DXO2013DrawChartStyle.ColorStyle);
  }
  
  private static bool CmpColorStyle(DXPack.ChartColorStylePart openXmlElement, DMDrawsChartsStyle.ColorStyle? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetColorStyle(DXPack.ChartColorStylePart openXmlElement, DMDrawsChartsStyle.ColorStyle? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsChartsStyle.ColorStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ColorStyle>(value);
       if (rootElement != null)
         openXmlElement.ColorStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ChartColorStylePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ChartColorStylePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.ChartColorStylePart? CreateModelElement(DXPack.ChartColorStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ChartColorStylePart();
      value.ColorStyle = GetColorStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ChartColorStylePart? openXmlElement, DMPack.ChartColorStylePart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorStyle(openXmlElement, value.ColorStyle, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartColorStylePart? value)
    where OpenXmlElementType: DXPack.ChartColorStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorStyle(openXmlElement, value?.ColorStyle);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
