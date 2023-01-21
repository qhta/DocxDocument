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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDrawsCharts.ErrorBarDirectionKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDrawsCharts.ErrorBarKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorBarValueType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDrawsCharts.ErrorKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NoEndCap>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Plus>();
    if (itemElement != null)
      return DMXDrawsCharts.PlusConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Minus>();
    if (itemElement != null)
      return DMXDrawsCharts.MinusConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ErrorBarValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.ErrorBars? CreateModelElement(DXDrawCharts.ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ErrorBars();
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
