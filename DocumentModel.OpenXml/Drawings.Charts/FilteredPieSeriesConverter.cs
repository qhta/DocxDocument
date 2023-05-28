namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public static class FilteredPieSeriesConverter
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  private static DMDC.PieChartSeries3? GetPieChartSeries(DXO13DC.FilteredPieSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.PieChartSeries>();
    if (element != null)
      return DMXDC.PieChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPieChartSeries(DXO13DC.FilteredPieSeries openXmlElement, DMDC.PieChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PieChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.PieChartSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetPieChartSeries(DXO13DC.FilteredPieSeries openXmlElement, DMDC.PieChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.PieChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PieChartSeries3Converter.CreateOpenXmlElement<DXO13DC.PieChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.FilteredPieSeries? CreateModelElement(DXO13DC.FilteredPieSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.FilteredPieSeries();
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredPieSeries? openXmlElement, DMDC.FilteredPieSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPieChartSeries(openXmlElement, value.PieChartSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredPieSeries value)
    where OpenXmlElementType: DXO13DC.FilteredPieSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredPieSeries openXmlElement, DMDC.FilteredPieSeries value)
  {
    SetPieChartSeries(openXmlElement, value?.PieChartSeries);
  }
}
