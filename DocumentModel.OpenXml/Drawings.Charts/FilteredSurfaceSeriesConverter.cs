namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public static class FilteredSurfaceSeriesConverter
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  private static DMDC.SurfaceChartSeries3? GetSurfaceChartSeries(DXO13DC.FilteredSurfaceSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.SurfaceChartSeries>();
    if (element != null)
      return DMXDC.SurfaceChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurfaceChartSeries(DXO13DC.FilteredSurfaceSeries openXmlElement, DMDC.SurfaceChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SurfaceChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.SurfaceChartSeries>(), value, diffs, objName);
  }
  
  private static void SetSurfaceChartSeries(DXO13DC.FilteredSurfaceSeries openXmlElement, DMDC.SurfaceChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.SurfaceChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SurfaceChartSeries3Converter.CreateOpenXmlElement<DXO13DC.SurfaceChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredSurfaceSeries? CreateModelElement(DXO13DC.FilteredSurfaceSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSurfaceSeries();
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredSurfaceSeries? openXmlElement, DMDC.FilteredSurfaceSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurfaceChartSeries(openXmlElement, value.SurfaceChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredSurfaceSeries value)
    where OpenXmlElementType: DXO13DC.FilteredSurfaceSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredSurfaceSeries openXmlElement, DMDC.FilteredSurfaceSeries value)
  {
    SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
  }
}
