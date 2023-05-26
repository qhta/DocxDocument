namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public static class ScatterChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.ScatterChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.ScatterChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.ScatterChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredScatterSeries? GetFilteredScatterSeries(DXDC.ScatterChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredScatterSeries>();
    if (element != null)
      return DMXDC.FilteredScatterSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredScatterSeries(DXDC.ScatterChartExtension openXmlElement, DMDC.FilteredScatterSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredScatterSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredScatterSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredScatterSeries(DXDC.ScatterChartExtension openXmlElement, DMDC.FilteredScatterSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredScatterSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredScatterSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredScatterSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartExtension? CreateModelElement(DXDC.ScatterChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredScatterSeries = GetFilteredScatterSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ScatterChartExtension? openXmlElement, DMDC.ScatterChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredScatterSeries(openXmlElement, value.FilteredScatterSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ScatterChartExtension value)
    where OpenXmlElementType: DXDC.ScatterChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ScatterChartExtension openXmlElement, DMDC.ScatterChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredScatterSeries(openXmlElement, value?.FilteredScatterSeries);
  }
}
