namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// ChartData.
  /// </summary>
  private static DMDrawsChartDraws.ChartData? GetChartData(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ChartData>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ChartDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartData(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ChartData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ChartData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ChartDataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ChartData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  private static DMDrawsChartDraws.Chart? GetChart(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Chart>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChart(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ChartConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Chart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TxPrTextBodyConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.TxPrTextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  private static DMDrawsChartDraws.ColorMappingType? GetColorMappingType(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ColorMappingType>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ColorMappingTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMappingType(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ColorMappingType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ColorMappingType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ColorMappingTypeConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ColorMappingType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  private static DMDrawsChartDraws.FormatOverrides? GetFormatOverrides(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.FormatOverrides>();
    if (itemElement != null)
      return DMXDrawsChartDraws.FormatOverridesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormatOverrides(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.FormatOverrides? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.FormatOverrides>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.FormatOverridesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.FormatOverrides>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  private static DMDrawsChartDraws.PrintSettings? GetPrintSettings(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PrintSettings>();
    if (itemElement != null)
      return DMXDrawsChartDraws.PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPrintSettings(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.PrintSettingsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.ChartSpace? CreateModelElement(DXO2016DrawChartDraw.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ChartSpace();
      value.ChartData = GetChartData(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ColorMappingType = GetColorMappingType(openXmlElement);
      value.FormatOverrides = GetFormatOverrides(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ChartSpace? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ChartSpace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartData(openXmlElement, value?.ChartData);
      SetChart(openXmlElement, value?.Chart);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetColorMappingType(openXmlElement, value?.ColorMappingType);
      SetFormatOverrides(openXmlElement, value?.FormatOverrides);
      SetPrintSettings(openXmlElement, value?.PrintSettings);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
