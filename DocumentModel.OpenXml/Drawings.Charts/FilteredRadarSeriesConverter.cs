namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public static class FilteredRadarSeriesConverter
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  private static DMDC.RadarChartSeries3? GetRadarChartSeries(DXO13DC.FilteredRadarSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.RadarChartSeries>();
    if (element != null)
      return DMXDC.RadarChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadarChartSeries(DXO13DC.FilteredRadarSeries openXmlElement, DMDC.RadarChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.RadarChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.RadarChartSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetRadarChartSeries(DXO13DC.FilteredRadarSeries openXmlElement, DMDC.RadarChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.RadarChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.RadarChartSeries3Converter.CreateOpenXmlElement<DXO13DC.RadarChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredRadarSeries? CreateModelElement(DXO13DC.FilteredRadarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredRadarSeries();
      value.RadarChartSeries = GetRadarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredRadarSeries? openXmlElement, DMDC.FilteredRadarSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadarChartSeries(openXmlElement, value.RadarChartSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredRadarSeries value)
    where OpenXmlElementType: DXO13DC.FilteredRadarSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredRadarSeries openXmlElement, DMDC.FilteredRadarSeries value)
  {
    SetRadarChartSeries(openXmlElement, value?.RadarChartSeries);
  }
}
