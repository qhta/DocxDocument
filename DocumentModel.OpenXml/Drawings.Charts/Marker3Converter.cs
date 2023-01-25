namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public static class Marker3Converter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  private static DMDrawsCharts.MarkerStyleKind? GetSymbol(DXO2013DrawChart.Marker openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDrawsCharts.MarkerStyleKind>(openXmlElement.GetFirstChild<DXDrawCharts.Symbol>()?.Val?.Value);
  }
  
  private static bool CmpSymbol(DXO2013DrawChart.Marker openXmlElement, DMDrawsCharts.MarkerStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDrawsCharts.MarkerStyleKind>(openXmlElement.GetFirstChild<DXDrawCharts.Symbol>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSymbol(DXO2013DrawChart.Marker openXmlElement, DMDrawsCharts.MarkerStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Symbol>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Symbol, DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDrawsCharts.MarkerStyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  private static Byte? GetSize(DXO2013DrawChart.Marker openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Size>()?.Val?.Value;
  }
  
  private static bool CmpSize(DXO2013DrawChart.Marker openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Size>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Size", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSize(DXO2013DrawChart.Marker openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Size>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Size{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXO2013DrawChart.Marker openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXO2013DrawChart.Marker openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXO2013DrawChart.Marker openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXO2013DrawChart.Marker openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2013DrawChart.Marker openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2013DrawChart.Marker openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Marker3? CreateModelElement(DXO2013DrawChart.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Marker3();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.Marker? openXmlElement, DMDrawsCharts.Marker3? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSymbol(openXmlElement, value.Symbol, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Marker3? value)
    where OpenXmlElementType: DXO2013DrawChart.Marker, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSymbol(openXmlElement, value?.Symbol);
      SetSize(openXmlElement, value?.Size);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
