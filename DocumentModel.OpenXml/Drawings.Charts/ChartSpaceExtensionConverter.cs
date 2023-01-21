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
  
  private static void SetUri(DXDrawCharts.ChartSpaceExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.PivotOptions? GetPivotOptions(DXDrawCharts.ChartSpaceExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawCharts.PivotOptions>();
    if (itemElement != null)
      return DMXDrawsCharts.PivotOptionsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawCharts.SketchOptions>();
    if (itemElement != null)
      return DMXDrawsCharts.SketchOptionsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.PivotSource>();
    if (itemElement != null)
      return DMXDrawsCharts.PivotSource3Converter.CreateModelElement(itemElement);
    return null;
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
