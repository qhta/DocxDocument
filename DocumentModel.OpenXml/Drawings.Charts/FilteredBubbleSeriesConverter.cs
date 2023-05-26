namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public static class FilteredBubbleSeriesConverter
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  private static DMDC.BubbleChartSeries3? GetBubbleChartSeries(DXO13DC.FilteredBubbleSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.BubbleChartSeries>();
    if (element != null)
      return DMXDC.BubbleChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleChartSeries(DXO13DC.FilteredBubbleSeries openXmlElement, DMDC.BubbleChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.BubbleChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.BubbleChartSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetBubbleChartSeries(DXO13DC.FilteredBubbleSeries openXmlElement, DMDC.BubbleChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.BubbleChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BubbleChartSeries3Converter.CreateOpenXmlElement<DXO13DC.BubbleChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredBubbleSeries? CreateModelElement(DXO13DC.FilteredBubbleSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredBubbleSeries();
      value.BubbleChartSeries = GetBubbleChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredBubbleSeries? openXmlElement, DMDC.FilteredBubbleSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBubbleChartSeries(openXmlElement, value.BubbleChartSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredBubbleSeries value)
    where OpenXmlElementType: DXO13DC.FilteredBubbleSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredBubbleSeries openXmlElement, DMDC.FilteredBubbleSeries value)
  {
    SetBubbleChartSeries(openXmlElement, value?.BubbleChartSeries);
  }
}
