namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// ChartData.
  /// </summary>
  private static DMDCDs.ChartData? GetChartData(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ChartData>();
    if (element != null)
      return DMXDCDs.ChartDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartData(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ChartData? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ChartDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ChartData>(), value, diffs, objName);
  }
  
  private static void SetChartData(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ChartData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ChartData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ChartDataConverter.CreateOpenXmlElement<DXO16DCD.ChartData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  private static DMDCDs.Chart? GetChart(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Chart>();
    if (element != null)
      return DMXDCDs.ChartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChart(DXO16DCD.ChartSpace openXmlElement, DMDCDs.Chart? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ChartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Chart>(), value, diffs, objName);
  }
  
  private static void SetChart(DXO16DCD.ChartSpace openXmlElement, DMDCDs.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ChartConverter.CreateOpenXmlElement<DXO16DCD.Chart>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  private static DMDCDs.TxPrTextBody? GetTxPrTextBody(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (element != null)
      return DMXDCDs.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO16DCD.ChartSpace openXmlElement, DMDCDs.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>(), value, diffs, objName);
  }
  
  private static void SetTxPrTextBody(DXO16DCD.ChartSpace openXmlElement, DMDCDs.TxPrTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.TxPrTextBodyConverter.CreateOpenXmlElement<DXO16DCD.TxPrTextBody>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  private static DMDCDs.ColorMappingType? GetColorMappingType(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ColorMappingType>();
    if (element != null)
      return DMXDCDs.ColorMappingTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMappingType(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ColorMappingType? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ColorMappingTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ColorMappingType>(), value, diffs, objName);
  }
  
  private static void SetColorMappingType(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ColorMappingType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ColorMappingType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ColorMappingTypeConverter.CreateOpenXmlElement<DXO16DCD.ColorMappingType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  private static DMDCDs.FormatOverrides? GetFormatOverrides(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.FormatOverrides>();
    if (element != null)
      return DMXDCDs.FormatOverridesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormatOverrides(DXO16DCD.ChartSpace openXmlElement, DMDCDs.FormatOverrides? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.FormatOverridesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.FormatOverrides>(), value, diffs, objName);
  }
  
  private static void SetFormatOverrides(DXO16DCD.ChartSpace openXmlElement, DMDCDs.FormatOverrides? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.FormatOverrides>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.FormatOverridesConverter.CreateOpenXmlElement<DXO16DCD.FormatOverrides>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  private static DMDCDs.PrintSettings? GetPrintSettings(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.PrintSettings>();
    if (element != null)
      return DMXDCDs.PrintSettingsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPrintSettings(DXO16DCD.ChartSpace openXmlElement, DMDCDs.PrintSettings? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.PrintSettingsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.PrintSettings>(), value, diffs, objName);
  }
  
  private static void SetPrintSettings(DXO16DCD.ChartSpace openXmlElement, DMDCDs.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.PrintSettingsConverter.CreateOpenXmlElement<DXO16DCD.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.ChartSpace openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ChartSpace? CreateModelElement(DXO16DCD.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartSpace();
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
  
  public static bool CompareModelElement(DXO16DCD.ChartSpace? openXmlElement, DMDCDs.ChartSpace? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ChartSpace value)
    where OpenXmlElementType: DXO16DCD.ChartSpace, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ChartSpace openXmlElement, DMDCDs.ChartSpace value)
  {
    SetChartData(openXmlElement, value?.ChartData);
    SetChart(openXmlElement, value?.Chart);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetColorMappingType(openXmlElement, value?.ColorMappingType);
    SetFormatOverrides(openXmlElement, value?.FormatOverrides);
    SetPrintSettings(openXmlElement, value?.PrintSettings);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
