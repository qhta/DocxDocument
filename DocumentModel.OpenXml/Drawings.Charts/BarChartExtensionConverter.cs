namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public static class BarChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.BarChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.BarChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.BarChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredBarSeries? GetFilteredBarSeries(DXDC.BarChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredBarSeries>();
    if (element != null)
      return DMXDC.FilteredBarSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredBarSeries(DXDC.BarChartExtension openXmlElement, DMDC.FilteredBarSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredBarSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredBarSeries>(), value, diffs, objName);
  }
  
  private static void SetFilteredBarSeries(DXDC.BarChartExtension openXmlElement, DMDC.FilteredBarSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredBarSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredBarSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredBarSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtension? CreateModelElement(DXDC.BarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BarChartExtension? openXmlElement, DMDC.BarChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredBarSeries(openXmlElement, value.FilteredBarSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BarChartExtension value)
    where OpenXmlElementType: DXDC.BarChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BarChartExtension openXmlElement, DMDC.BarChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredBarSeries(openXmlElement, value?.FilteredBarSeries);
  }
}
