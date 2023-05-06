namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public static class PieChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.PieChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.PieChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.PieChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredPieSeries? GetFilteredPieSeries(DXDC.PieChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredPieSeries>();
    if (element != null)
      return DMXDC.FilteredPieSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredPieSeries(DXDC.PieChartExtension openXmlElement, DMDC.FilteredPieSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredPieSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredPieSeries>(), value, diffs, objName);
  }
  
  private static void SetFilteredPieSeries(DXDC.PieChartExtension openXmlElement, DMDC.FilteredPieSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredPieSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredPieSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredPieSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChartExtension? CreateModelElement(DXDC.PieChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PieChartExtension? openXmlElement, DMDC.PieChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredPieSeries(openXmlElement, value.FilteredPieSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PieChartExtension value)
    where OpenXmlElementType: DXDC.PieChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PieChartExtension openXmlElement, DMDC.PieChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredPieSeries(openXmlElement, value?.FilteredPieSeries);
  }
}
