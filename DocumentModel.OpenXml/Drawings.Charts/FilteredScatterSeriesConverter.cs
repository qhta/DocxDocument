namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public static class FilteredScatterSeriesConverter
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  private static DMDC.ScatterChartSeries3? GetScatterChartSeries(DXO13DC.FilteredScatterSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.ScatterChartSeries>();
    if (element != null)
      return DMXDC.ScatterChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScatterChartSeries(DXO13DC.FilteredScatterSeries openXmlElement, DMDC.ScatterChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ScatterChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.ScatterChartSeries>(), value, diffs, objName);
  }
  
  private static void SetScatterChartSeries(DXO13DC.FilteredScatterSeries openXmlElement, DMDC.ScatterChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.ScatterChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ScatterChartSeries3Converter.CreateOpenXmlElement<DXO13DC.ScatterChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredScatterSeries? CreateModelElement(DXO13DC.FilteredScatterSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredScatterSeries();
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredScatterSeries? openXmlElement, DMDC.FilteredScatterSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterChartSeries(openXmlElement, value.ScatterChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredScatterSeries value)
    where OpenXmlElementType: DXO13DC.FilteredScatterSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredScatterSeries openXmlElement, DMDC.FilteredScatterSeries value)
  {
    SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
  }
}
