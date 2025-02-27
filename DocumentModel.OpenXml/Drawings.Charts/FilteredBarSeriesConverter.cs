namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public static class FilteredBarSeriesConverter
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  private static DMDC.BarChartSeries3? GetBarChartSeries(DXO13DC.FilteredBarSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.BarChartSeries>();
    if (element != null)
      return DMXDC.BarChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarChartSeries(DXO13DC.FilteredBarSeries openXmlElement, DMDC.BarChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.BarChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.BarChartSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetBarChartSeries(DXO13DC.FilteredBarSeries openXmlElement, DMDC.BarChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.BarChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BarChartSeries3Converter.CreateOpenXmlElement<DXO13DC.BarChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.FilteredBarSeries? CreateModelElement(DXO13DC.FilteredBarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.FilteredBarSeries();
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredBarSeries? openXmlElement, DMDC.FilteredBarSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarChartSeries(openXmlElement, value.BarChartSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredBarSeries value)
    where OpenXmlElementType: DXO13DC.FilteredBarSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredBarSeries openXmlElement, DMDC.FilteredBarSeries value)
  {
    SetBarChartSeries(openXmlElement, value?.BarChartSeries);
  }
}
