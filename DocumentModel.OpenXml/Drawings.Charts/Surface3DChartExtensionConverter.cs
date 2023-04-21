namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public static class Surface3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.Surface3DChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.Surface3DChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.Surface3DChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.FilteredSurfaceSeries? GetFilteredSurfaceSeries(DXDC.Surface3DChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.FilteredSurfaceSeries>();
    if (element != null)
      return DMXDC.FilteredSurfaceSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredSurfaceSeries(DXDC.Surface3DChartExtension openXmlElement, DMDC.FilteredSurfaceSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FilteredSurfaceSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.FilteredSurfaceSeries>(), value, diffs, objName);
  }
  
  private static void SetFilteredSurfaceSeries(DXDC.Surface3DChartExtension openXmlElement, DMDC.FilteredSurfaceSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.FilteredSurfaceSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FilteredSurfaceSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredSurfaceSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Surface3DChartExtension? CreateModelElement(DXDC.Surface3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Surface3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSurfaceSeries = GetFilteredSurfaceSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Surface3DChartExtension? openXmlElement, DMDC.Surface3DChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredSurfaceSeries(openXmlElement, value.FilteredSurfaceSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Surface3DChartExtension value)
    where OpenXmlElementType: DXDC.Surface3DChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Surface3DChartExtension openXmlElement, DMDC.Surface3DChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredSurfaceSeries(openXmlElement, value?.FilteredSurfaceSeries);
  }
}
