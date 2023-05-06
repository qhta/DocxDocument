namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public static class AreaChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.AreaChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.AreaChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.AreaChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredAreaSeries? GetFilteredAreaSeries(DXDC.AreaChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredAreaSeries>();
    if (element != null)
      return DMXDC.FilteredAreaSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredAreaSeries(DXDC.AreaChartExtension openXmlElement, DMDC.FilteredAreaSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredAreaSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredAreaSeries>(), value, diffs, objName);
  }
  
  private static void SetFilteredAreaSeries(DXDC.AreaChartExtension openXmlElement, DMDC.FilteredAreaSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredAreaSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredAreaSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredAreaSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.AreaChartExtension? CreateModelElement(DXDC.AreaChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredAreaSeries = GetFilteredAreaSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.AreaChartExtension? openXmlElement, DMDC.AreaChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredAreaSeries(openXmlElement, value.FilteredAreaSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.AreaChartExtension value)
    where OpenXmlElementType: DXDC.AreaChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.AreaChartExtension openXmlElement, DMDC.AreaChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredAreaSeries(openXmlElement, value?.FilteredAreaSeries);
  }
}
