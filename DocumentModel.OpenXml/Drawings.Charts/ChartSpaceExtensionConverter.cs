namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public static class ChartSpaceExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.ChartSpaceExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.ChartSpaceExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.ChartSpaceExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.PivotOptions? GetPivotOptions(DXDrawCharts.ChartSpaceExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawCharts.PivotOptions>();
    if (element != null)
      return DMXDrawsCharts.PivotOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotOptions(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.PivotOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PivotOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawCharts.PivotOptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPivotOptions(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.PivotOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.PivotOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PivotOptionsConverter.CreateOpenXmlElement<DXO2010DrawCharts.PivotOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.SketchOptions? GetSketchOptions(DXDrawCharts.ChartSpaceExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawCharts.SketchOptions>();
    if (element != null)
      return DMXDrawsCharts.SketchOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSketchOptions(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.SketchOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SketchOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawCharts.SketchOptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSketchOptions(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.SketchOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.SketchOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SketchOptionsConverter.CreateOpenXmlElement<DXO2010DrawCharts.SketchOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PivotSource3? GetPivotSource(DXDrawCharts.ChartSpaceExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.PivotSource>();
    if (element != null)
      return DMXDrawsCharts.PivotSource3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotSource(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.PivotSource3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PivotSource3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.PivotSource>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPivotSource(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.PivotSource3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PivotSource3Converter.CreateOpenXmlElement<DXO2013DrawChart.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpaceExtension? CreateModelElement(DXDrawCharts.ChartSpaceExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtension();
      value.Uri = GetUri(openXmlElement);
      value.PivotOptions = GetPivotOptions(openXmlElement);
      value.SketchOptions = GetSketchOptions(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ChartSpaceExtension? openXmlElement, DMDrawsCharts.ChartSpaceExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpPivotOptions(openXmlElement, value.PivotOptions, diffs, objName))
        ok = false;
      if (!CmpSketchOptions(openXmlElement, value.SketchOptions, diffs, objName))
        ok = false;
      if (!CmpPivotSource(openXmlElement, value.PivotSource, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartSpaceExtension value)
    where OpenXmlElementType: DXDrawCharts.ChartSpaceExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ChartSpaceExtension openXmlElement, DMDrawsCharts.ChartSpaceExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetPivotOptions(openXmlElement, value?.PivotOptions);
    SetSketchOptions(openXmlElement, value?.SketchOptions);
    SetPivotSource(openXmlElement, value?.PivotSource);
  }
}
