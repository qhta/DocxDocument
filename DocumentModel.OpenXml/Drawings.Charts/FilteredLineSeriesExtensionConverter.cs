namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public static class FilteredLineSeriesExtensionConverter
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  private static DMDC.LineChartSeries3? GetLineChartSeries(DXO13DC.FilteredLineSeriesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.LineChartSeries>();
    if (element != null)
      return DMXDC.LineChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineChartSeries(DXO13DC.FilteredLineSeriesExtension openXmlElement, DMDC.LineChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.LineChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.LineChartSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetLineChartSeries(DXO13DC.FilteredLineSeriesExtension openXmlElement, DMDC.LineChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.LineChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LineChartSeries3Converter.CreateOpenXmlElement<DXO13DC.LineChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.FilteredLineSeriesExtension? CreateModelElement(DXO13DC.FilteredLineSeriesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.FilteredLineSeriesExtension();
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredLineSeriesExtension? openXmlElement, DMDC.FilteredLineSeriesExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineChartSeries(openXmlElement, value.LineChartSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredLineSeriesExtension value)
    where OpenXmlElementType: DXO13DC.FilteredLineSeriesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredLineSeriesExtension openXmlElement, DMDC.FilteredLineSeriesExtension value)
  {
    SetLineChartSeries(openXmlElement, value?.LineChartSeries);
  }
}
