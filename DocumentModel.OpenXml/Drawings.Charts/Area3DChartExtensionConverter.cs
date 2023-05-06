namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public static class Area3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.Area3DChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.Area3DChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.Area3DChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredAreaSeries? GetFilteredAreaSeries(DXDC.Area3DChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredAreaSeries>();
    if (element != null)
      return DMXDC.FilteredAreaSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredAreaSeries(DXDC.Area3DChartExtension openXmlElement, DMDC.FilteredAreaSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredAreaSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredAreaSeries>(), value, diffs, objName);
  }
  
  private static void SetFilteredAreaSeries(DXDC.Area3DChartExtension openXmlElement, DMDC.FilteredAreaSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredAreaSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredAreaSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredAreaSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChartExtension? CreateModelElement(DXDC.Area3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Area3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredAreaSeries = GetFilteredAreaSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Area3DChartExtension? openXmlElement, DMDC.Area3DChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredAreaSeries(openXmlElement, value.FilteredAreaSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Area3DChartExtension value)
    where OpenXmlElementType: DXDC.Area3DChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Area3DChartExtension openXmlElement, DMDC.Area3DChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredAreaSeries(openXmlElement, value?.FilteredAreaSeries);
  }
}
