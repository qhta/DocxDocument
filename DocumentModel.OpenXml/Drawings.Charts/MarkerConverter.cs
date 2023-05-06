namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Marker.
/// </summary>
public static class MarkerConverter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  private static DMDC.MarkerStyleKind? GetSymbol(DXDC.Marker openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(openXmlElement.GetFirstChild<DXDC.Symbol>()?.Val?.Value);
  }
  
  private static bool CmpSymbol(DXDC.Marker openXmlElement, DMDC.MarkerStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(openXmlElement.GetFirstChild<DXDC.Symbol>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSymbol(DXDC.Marker openXmlElement, DMDC.MarkerStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Symbol>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(itemElement, (DMDC.MarkerStyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Symbol, DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>((DMDC.MarkerStyleKind)value));
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  private static Byte? GetSize(DXDC.Marker openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Size>()?.Val);
  }
  
  private static bool CmpSize(DXDC.Marker openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Size>()?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetSize(DXDC.Marker openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDC.Size,System.Byte>(openXmlElement, value);
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.Marker openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.Marker openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.Marker openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.Marker openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.Marker openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.Marker openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Marker? CreateModelElement(DXDC.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Marker();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Marker? openXmlElement, DMDC.Marker? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Marker value)
    where OpenXmlElementType: DXDC.Marker, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Marker openXmlElement, DMDC.Marker value)
  {
    SetSymbol(openXmlElement, value?.Symbol);
    SetSize(openXmlElement, value?.Size);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
