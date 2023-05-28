namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public static class Line3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.Line3DChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.Line3DChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.Line3DChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DXDC.Line3DChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredLineSeriesExtension>();
    if (element != null)
      return DMXDC.FilteredLineSeriesExtensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredLineSeriesExtension(DXDC.Line3DChartExtension openXmlElement, DMDC.FilteredLineSeriesExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredLineSeriesExtensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredLineSeriesExtension>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredLineSeriesExtension(DXDC.Line3DChartExtension openXmlElement, DMDC.FilteredLineSeriesExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredLineSeriesExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DXO13DC.FilteredLineSeriesExtension>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.Line3DChartExtension? CreateModelElement(DXDC.Line3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Line3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Line3DChartExtension? openXmlElement, DMDC.Line3DChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredLineSeriesExtension(openXmlElement, value.FilteredLineSeriesExtension, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Line3DChartExtension value)
    where OpenXmlElementType: DXDC.Line3DChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Line3DChartExtension openXmlElement, DMDC.Line3DChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredLineSeriesExtension(openXmlElement, value?.FilteredLineSeriesExtension);
  }
}
