namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public static class Bar3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.Bar3DChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.Bar3DChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.Bar3DChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredBarSeries? GetFilteredBarSeries(DXDC.Bar3DChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredBarSeries>();
    if (element != null)
      return DMXDC.FilteredBarSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredBarSeries(DXDC.Bar3DChartExtension openXmlElement, DMDC.FilteredBarSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredBarSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredBarSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredBarSeries(DXDC.Bar3DChartExtension openXmlElement, DMDC.FilteredBarSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredBarSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredBarSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredBarSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.Bar3DChartExtension? CreateModelElement(DXDC.Bar3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Bar3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Bar3DChartExtension? openXmlElement, DMDC.Bar3DChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredBarSeries(openXmlElement, value.FilteredBarSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Bar3DChartExtension value)
    where OpenXmlElementType: DXDC.Bar3DChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Bar3DChartExtension openXmlElement, DMDC.Bar3DChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredBarSeries(openXmlElement, value?.FilteredBarSeries);
  }
}
