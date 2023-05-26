namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public static class Pie3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.Pie3DChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.Pie3DChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.Pie3DChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredPieSeries? GetFilteredPieSeries(DXDC.Pie3DChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredPieSeries>();
    if (element != null)
      return DMXDC.FilteredPieSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredPieSeries(DXDC.Pie3DChartExtension openXmlElement, DMDC.FilteredPieSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredPieSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredPieSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredPieSeries(DXDC.Pie3DChartExtension openXmlElement, DMDC.FilteredPieSeries? value)
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
  
  public static DocumentModel.Drawings.Charts.Pie3DChartExtension? CreateModelElement(DXDC.Pie3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Pie3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Pie3DChartExtension? openXmlElement, DMDC.Pie3DChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredPieSeries(openXmlElement, value.FilteredPieSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Pie3DChartExtension value)
    where OpenXmlElementType: DXDC.Pie3DChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Pie3DChartExtension openXmlElement, DMDC.Pie3DChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredPieSeries(openXmlElement, value?.FilteredPieSeries);
  }
}
