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
  
  private static bool CmpUri(DXDC.BarChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpFilteredBarSeries(DXDC.BarChartExtension openXmlElement, DMDC.FilteredBarSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredBarSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredBarSeries>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.BarChartExtension? CreateModelElement(DXDC.BarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.BarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BarChartExtension? openXmlElement, DMDC.BarChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
