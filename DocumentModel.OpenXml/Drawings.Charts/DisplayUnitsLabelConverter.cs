namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Display Units Label.
/// </summary>
public static class DisplayUnitsLabelConverter
{
  /// <summary>
  /// Layout.
  /// </summary>
  private static DMDrawsCharts.Layout? GetLayout(DXDrawCharts.DisplayUnitsLabel openXmlElement)
  {
    return DMXDrawsCharts.LayoutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Layout>());
  }
  
  private static bool CmpLayout(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.Layout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LayoutConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Layout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayout(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.Layout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LayoutConverter.CreateOpenXmlElement<DXDrawCharts.Layout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  private static DMDrawsCharts.ChartText? GetChartText(DXDrawCharts.DisplayUnitsLabel openXmlElement)
  {
    return DMXDrawsCharts.ChartTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartText>());
  }
  
  private static bool CmpChartText(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.ChartText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartTextConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartText(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.ChartText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartTextConverter.CreateOpenXmlElement<DXDrawCharts.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.DisplayUnitsLabel openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.DisplayUnitsLabel openXmlElement)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>());
  }
  
  private static bool CmpTextProperties(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXDrawCharts.DisplayUnitsLabel openXmlElement, DMDrawsCharts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TextPropertiesConverter.CreateOpenXmlElement<DXDrawCharts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.DisplayUnitsLabel? CreateModelElement(DXDrawCharts.DisplayUnitsLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DisplayUnitsLabel();
      value.Layout = GetLayout(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DisplayUnitsLabel? openXmlElement, DMDrawsCharts.DisplayUnitsLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DisplayUnitsLabel? value)
    where OpenXmlElementType: DXDrawCharts.DisplayUnitsLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLayout(openXmlElement, value?.Layout);
      SetChartText(openXmlElement, value?.ChartText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      return openXmlElement;
    }
    return default;
  }
}
