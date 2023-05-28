namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public static class BubbleChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.BubbleChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.BubbleChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.BubbleChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredBubbleSeries? GetFilteredBubbleSeries(DXDC.BubbleChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredBubbleSeries>();
    if (element != null)
      return DMXDC.FilteredBubbleSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredBubbleSeries(DXDC.BubbleChartExtension openXmlElement, DMDC.FilteredBubbleSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredBubbleSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredBubbleSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredBubbleSeries(DXDC.BubbleChartExtension openXmlElement, DMDC.FilteredBubbleSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredBubbleSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredBubbleSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredBubbleSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.BubbleChartExtension? CreateModelElement(DXDC.BubbleChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.BubbleChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBubbleSeries = GetFilteredBubbleSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BubbleChartExtension? openXmlElement, DMDC.BubbleChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredBubbleSeries(openXmlElement, value.FilteredBubbleSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BubbleChartExtension value)
    where OpenXmlElementType: DXDC.BubbleChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BubbleChartExtension openXmlElement, DMDC.BubbleChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredBubbleSeries(openXmlElement, value?.FilteredBubbleSeries);
  }
}
