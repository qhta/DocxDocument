namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public static class SurfaceChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.SurfaceChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.SurfaceChartExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.SurfaceChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredSurfaceSeries? GetFilteredSurfaceSeries(DXDC.SurfaceChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredSurfaceSeries>();
    if (element != null)
      return DMXDC.FilteredSurfaceSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSurfaceSeries(DXDC.SurfaceChartExtension openXmlElement, DMDC.FilteredSurfaceSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.FilteredSurfaceSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredSurfaceSeries>(), value, diffs, objName, propName);
  }
  
  private static void SetFilteredSurfaceSeries(DXDC.SurfaceChartExtension openXmlElement, DMDC.FilteredSurfaceSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredSurfaceSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredSurfaceSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredSurfaceSeries>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.SurfaceChartExtension? CreateModelElement(DXDC.SurfaceChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.SurfaceChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSurfaceSeries = GetFilteredSurfaceSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SurfaceChartExtension? openXmlElement, DMDC.SurfaceChartExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpFilteredSurfaceSeries(openXmlElement, value.FilteredSurfaceSeries, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SurfaceChartExtension value)
    where OpenXmlElementType: DXDC.SurfaceChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SurfaceChartExtension openXmlElement, DMDC.SurfaceChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredSurfaceSeries(openXmlElement, value?.FilteredSurfaceSeries);
  }
}
