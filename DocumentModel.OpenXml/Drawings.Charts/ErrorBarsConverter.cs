namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public static class ErrorBarsConverter
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  private static DMDC.ErrorBarDirectionKind? GetErrorDirection(DXDC.ErrorBars openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>(openXmlElement.GetFirstChild<DXDC.ErrorDirection>()?.Val?.Value);
  }
  
  private static bool CmpErrorDirection(DXDC.ErrorBars openXmlElement, DMDC.ErrorBarDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>(openXmlElement.GetFirstChild<DXDC.ErrorDirection>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetErrorDirection(DXDC.ErrorBars openXmlElement, DMDC.ErrorBarDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ErrorDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>(itemElement, (DMDC.ErrorBarDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ErrorDirection, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>((DMDC.ErrorBarDirectionKind)value));
  }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  private static DMDC.ErrorBarKind? GetErrorBarType(DXDC.ErrorBars openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>(openXmlElement.GetFirstChild<DXDC.ErrorBarType>()?.Val?.Value);
  }
  
  private static bool CmpErrorBarType(DXDC.ErrorBars openXmlElement, DMDC.ErrorBarKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>(openXmlElement.GetFirstChild<DXDC.ErrorBarType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetErrorBarType(DXDC.ErrorBars openXmlElement, DMDC.ErrorBarKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ErrorBarType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>(itemElement, (DMDC.ErrorBarKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ErrorBarType, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>((DMDC.ErrorBarKind)value));
  }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  private static DMDC.ErrorKind? GetErrorBarValueType(DXDC.ErrorBars openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>(openXmlElement.GetFirstChild<DXDC.ErrorBarValueType>()?.Val?.Value);
  }
  
  private static bool CmpErrorBarValueType(DXDC.ErrorBars openXmlElement, DMDC.ErrorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>(openXmlElement.GetFirstChild<DXDC.ErrorBarValueType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetErrorBarValueType(DXDC.ErrorBars openXmlElement, DMDC.ErrorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ErrorBarValueType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>(itemElement, (DMDC.ErrorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ErrorBarValueType, DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>((DMDC.ErrorKind)value));
  }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  private static Boolean? GetNoEndCap(DXDC.ErrorBars openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.NoEndCap>() != null;
  }
  
  private static bool CmpNoEndCap(DXDC.ErrorBars openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.NoEndCap>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.NoEndCap", val, value);
    return false;
  }
  
  private static void SetNoEndCap(DXDC.ErrorBars openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.NoEndCap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.NoEndCap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Plus.
  /// </summary>
  private static DMDC.Plus? GetPlus(DXDC.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Plus>();
    if (element != null)
      return DMXDC.PlusConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlus(DXDC.ErrorBars openXmlElement, DMDC.Plus? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PlusConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Plus>(), value, diffs, objName);
  }
  
  private static void SetPlus(DXDC.ErrorBars openXmlElement, DMDC.Plus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Plus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PlusConverter.CreateOpenXmlElement<DXDC.Plus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minus.
  /// </summary>
  private static DMDC.Minus? GetMinus(DXDC.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Minus>();
    if (element != null)
      return DMXDC.MinusConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinus(DXDC.ErrorBars openXmlElement, DMDC.Minus? value, DiffList? diffs, string? objName)
  {
    return DMXDC.MinusConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Minus>(), value, diffs, objName);
  }
  
  private static void SetMinus(DXDC.ErrorBars openXmlElement, DMDC.Minus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Minus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MinusConverter.CreateOpenXmlElement<DXDC.Minus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  private static Double? GetErrorBarValue(DXDC.ErrorBars openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.ErrorBarValue>()?.Val);
  }
  
  private static bool CmpErrorBarValue(DXDC.ErrorBars openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.ErrorBarValue>()?.Val, value, diffs, objName, "ErrorBarValue");
  }
  
  private static void SetErrorBarValue(DXDC.ErrorBars openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.ErrorBarValue,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.ErrorBars openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.ErrorBars openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.ErrorBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.ErrorBars openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.ErrorBars openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ErrorBars? CreateModelElement(DXDC.ErrorBars? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.ErrorBars? openXmlElement, DMDC.ErrorBars? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ErrorBars value)
    where OpenXmlElementType: DXDC.ErrorBars, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ErrorBars openXmlElement, DMDC.ErrorBars value)
  {
    SetErrorDirection(openXmlElement, value?.ErrorDirection);
    SetErrorBarType(openXmlElement, value?.ErrorBarType);
    SetErrorBarValueType(openXmlElement, value?.ErrorBarValueType);
    SetNoEndCap(openXmlElement, value?.NoEndCap);
    SetPlus(openXmlElement, value?.Plus);
    SetMinus(openXmlElement, value?.Minus);
    SetErrorBarValue(openXmlElement, value?.ErrorBarValue);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
