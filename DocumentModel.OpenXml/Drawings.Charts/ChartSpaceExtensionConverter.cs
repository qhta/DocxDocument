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
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.ChartSpaceExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.ChartSpaceExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.PivotOptions? GetPivotOptions(DXDrawCharts.ChartSpaceExtension openXmlElement)
  {
    return DMXDrawsCharts.PivotOptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010DrawCharts.PivotOptions>());
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
    return DMXDrawsCharts.SketchOptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010DrawCharts.SketchOptions>());
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
    return DMXDrawsCharts.PivotSource3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.PivotSource>());
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
  
  public static DMDrawsCharts.ChartSpaceExtension? CreateModelElement(DXDrawCharts.ChartSpaceExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ChartSpaceExtension();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartSpaceExtension? value)
    where OpenXmlElementType: DXDrawCharts.ChartSpaceExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetPivotOptions(openXmlElement, value?.PivotOptions);
      SetSketchOptions(openXmlElement, value?.SketchOptions);
      SetPivotSource(openXmlElement, value?.PivotSource);
      return openXmlElement;
    }
    return default;
  }
}
