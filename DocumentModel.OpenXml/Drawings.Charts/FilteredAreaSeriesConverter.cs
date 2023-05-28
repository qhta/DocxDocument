namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public static class FilteredAreaSeriesConverter
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  private static DMDC.AreaChartSeries3? GetAreaChartSeries(DXO13DC.FilteredAreaSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.AreaChartSeries>();
    if (element != null)
      return DMXDC.AreaChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAreaChartSeries(DXO13DC.FilteredAreaSeries openXmlElement, DMDC.AreaChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.AreaChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.AreaChartSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetAreaChartSeries(DXO13DC.FilteredAreaSeries openXmlElement, DMDC.AreaChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.AreaChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.AreaChartSeries3Converter.CreateOpenXmlElement<DXO13DC.AreaChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.FilteredAreaSeries? CreateModelElement(DXO13DC.FilteredAreaSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.FilteredAreaSeries();
      value.AreaChartSeries = GetAreaChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredAreaSeries? openXmlElement, DMDC.FilteredAreaSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaChartSeries(openXmlElement, value.AreaChartSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredAreaSeries value)
    where OpenXmlElementType: DXO13DC.FilteredAreaSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredAreaSeries openXmlElement, DMDC.FilteredAreaSeries value)
  {
    SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
  }
}
