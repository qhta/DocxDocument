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
    return DMXDrawsChartDraws.ChartDataConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ChartData>());
  }
  
  private static bool CmpChartData(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ChartData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ChartDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ChartData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.ChartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Chart>());
  }
  
  private static bool CmpChart(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.Chart? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Chart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>());
  }
  
  private static bool CmpTxPrTextBody(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.ColorMappingTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ColorMappingType>());
  }
  
  private static bool CmpColorMappingType(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ColorMappingType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ColorMappingTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ColorMappingType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.FormatOverridesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.FormatOverrides>());
  }
  
  private static bool CmpFormatOverrides(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.FormatOverrides? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.FormatOverridesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.FormatOverrides>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.PrintSettingsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PrintSettings>());
  }
  
  private static bool CmpPrintSettings(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.PrintSettings? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.PrintSettingsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PrintSettings>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.ChartSpace openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ChartSpace? openXmlElement, DMDrawsChartDraws.ChartSpace? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartData(openXmlElement, value.ChartData, diffs, objName))
        ok = false;
      if (!CmpChart(openXmlElement, value.Chart, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTxPrTextBody(openXmlElement, value.TxPrTextBody, diffs, objName))
        ok = false;
      if (!CmpColorMappingType(openXmlElement, value.ColorMappingType, diffs, objName))
        ok = false;
      if (!CmpFormatOverrides(openXmlElement, value.FormatOverrides, diffs, objName))
        ok = false;
      if (!CmpPrintSettings(openXmlElement, value.PrintSettings, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
