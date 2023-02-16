namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public static class ErrorBarsConverter
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  private static DMDrawsCharts.ErrorBarDirectionKind? GetErrorDirection(DXDrawCharts.ErrorBars openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDrawsCharts.ErrorBarDirectionKind>(openXmlElement.GetFirstChild<DXDrawCharts.ErrorDirection>()?.Val?.Value);
  }
  
  private static bool CmpErrorDirection(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ErrorBarDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDrawsCharts.ErrorBarDirectionKind>(openXmlElement.GetFirstChild<DXDrawCharts.ErrorDirection>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetErrorDirection(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ErrorBarDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.ErrorDirection, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDrawsCharts.ErrorBarDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  private static DMDrawsCharts.ErrorBarKind? GetErrorBarType(DXDrawCharts.ErrorBars openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDrawsCharts.ErrorBarKind>(openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarType>()?.Val?.Value);
  }
  
  private static bool CmpErrorBarType(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ErrorBarKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDrawsCharts.ErrorBarKind>(openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetErrorBarType(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ErrorBarKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.ErrorBarType, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDrawsCharts.ErrorBarKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  private static DMDrawsCharts.ErrorKind? GetErrorBarValueType(DXDrawCharts.ErrorBars openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDrawsCharts.ErrorKind>(openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarValueType>()?.Val?.Value);
  }
  
  private static bool CmpErrorBarValueType(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ErrorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDrawsCharts.ErrorKind>(openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarValueType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetErrorBarValueType(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ErrorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarValueType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.ErrorBarValueType, DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDrawsCharts.ErrorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  private static Boolean? GetNoEndCap(DXDrawCharts.ErrorBars openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.NoEndCap>() != null;
  }
  
  private static bool CmpNoEndCap(DXDrawCharts.ErrorBars openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.NoEndCap>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.NoEndCap", val, value);
    return false;
  }
  
  private static void SetNoEndCap(DXDrawCharts.ErrorBars openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NoEndCap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.NoEndCap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Plus.
  /// </summary>
  private static DMDrawsCharts.Plus? GetPlus(DXDrawCharts.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Plus>();
    if (element != null)
      return DMXDrawsCharts.PlusConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlus(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.Plus? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PlusConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Plus>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPlus(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.Plus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Plus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PlusConverter.CreateOpenXmlElement<DXDrawCharts.Plus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minus.
  /// </summary>
  private static DMDrawsCharts.Minus? GetMinus(DXDrawCharts.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Minus>();
    if (element != null)
      return DMXDrawsCharts.MinusConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinus(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.Minus? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MinusConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Minus>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinus(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.Minus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Minus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MinusConverter.CreateOpenXmlElement<DXDrawCharts.Minus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  private static Double? GetErrorBarValue(DXDrawCharts.ErrorBars openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.ErrorBarValue>()?.Val?.Value;
  }
  
  private static bool CmpErrorBarValue(DXDrawCharts.ErrorBars openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ErrorBarValue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ErrorBarValue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetErrorBarValue(DXDrawCharts.ErrorBars openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.ErrorBarValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.ErrorBars openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.ErrorBars? CreateModelElement(DXDrawCharts.ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ErrorBars();
      value.ErrorDirection = GetErrorDirection(openXmlElement);
      value.ErrorBarType = GetErrorBarType(openXmlElement);
      value.ErrorBarValueType = GetErrorBarValueType(openXmlElement);
      value.NoEndCap = GetNoEndCap(openXmlElement);
      value.Plus = GetPlus(openXmlElement);
      value.Minus = GetMinus(openXmlElement);
      value.ErrorBarValue = GetErrorBarValue(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ErrorBars? openXmlElement, DMDrawsCharts.ErrorBars? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpErrorDirection(openXmlElement, value.ErrorDirection, diffs, objName))
        ok = false;
      if (!CmpErrorBarType(openXmlElement, value.ErrorBarType, diffs, objName))
        ok = false;
      if (!CmpErrorBarValueType(openXmlElement, value.ErrorBarValueType, diffs, objName))
        ok = false;
      if (!CmpNoEndCap(openXmlElement, value.NoEndCap, diffs, objName))
        ok = false;
      if (!CmpPlus(openXmlElement, value.Plus, diffs, objName))
        ok = false;
      if (!CmpMinus(openXmlElement, value.Minus, diffs, objName))
        ok = false;
      if (!CmpErrorBarValue(openXmlElement, value.ErrorBarValue, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ErrorBars? value)
    where OpenXmlElementType: DXDrawCharts.ErrorBars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetErrorDirection(openXmlElement, value?.ErrorDirection);
      SetErrorBarType(openXmlElement, value?.ErrorBarType);
      SetErrorBarValueType(openXmlElement, value?.ErrorBarValueType);
      SetNoEndCap(openXmlElement, value?.NoEndCap);
      SetPlus(openXmlElement, value?.Plus);
      SetMinus(openXmlElement, value?.Minus);
      SetErrorBarValue(openXmlElement, value?.ErrorBarValue);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
