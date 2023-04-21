namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public static class RadarChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.RadarChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.RadarChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.RadarChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredRadarSeries? GetFilteredRadarSeries(DXDC.RadarChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredRadarSeries>();
    if (element != null)
      return DMXDC.FilteredRadarSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredRadarSeries(DXDC.RadarChartExtension openXmlElement, DMDC.FilteredRadarSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredRadarSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredRadarSeries>(), value, diffs, objName);
  }
  
  private static void SetFilteredRadarSeries(DXDC.RadarChartExtension openXmlElement, DMDC.FilteredRadarSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredRadarSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredRadarSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredRadarSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarChartExtension? CreateModelElement(DXDC.RadarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredRadarSeries = GetFilteredRadarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.RadarChartExtension? openXmlElement, DMDC.RadarChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredRadarSeries(openXmlElement, value.FilteredRadarSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.RadarChartExtension value)
    where OpenXmlElementType: DXDC.RadarChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.RadarChartExtension openXmlElement, DMDC.RadarChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredRadarSeries(openXmlElement, value?.FilteredRadarSeries);
  }
}
