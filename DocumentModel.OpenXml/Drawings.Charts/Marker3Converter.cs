namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public static class Marker3Converter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  private static DMDC.MarkerStyleKind? GetSymbol(DXO13DC.Marker openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(openXmlElement.GetFirstChild<DXDC.Symbol>()?.Val?.Value);
  }
  
  private static bool CmpSymbol(DXO13DC.Marker openXmlElement, DMDC.MarkerStyleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(openXmlElement.GetFirstChild<DXDC.Symbol>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetSymbol(DXO13DC.Marker openXmlElement, DMDC.MarkerStyleKind? value)
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
  private static Byte? GetSize(DXO13DC.Marker openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Size>()?.Val);
  }
  
  private static bool CmpSize(DXO13DC.Marker openXmlElement, Byte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Size>()?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetSize(DXO13DC.Marker openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDC.Size,System.Byte>(openXmlElement, value);
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXO13DC.Marker openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXO13DC.Marker openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXO13DC.Marker openXmlElement, DMDC.ChartShapeProperties? value)
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
  private static DMDC.ExtensionList? GetExtensionList(DXO13DC.Marker openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO13DC.Marker openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO13DC.Marker openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DMD.Charts.Marker3? CreateModelElement(DXO13DC.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Marker3();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.Marker? openXmlElement, DMDC.Marker3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSymbol(openXmlElement, value.Symbol, diffs, objName, propName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Marker3 value)
    where OpenXmlElementType: DXO13DC.Marker, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.Marker openXmlElement, DMDC.Marker3 value)
  {
    SetSymbol(openXmlElement, value?.Symbol);
    SetSize(openXmlElement, value?.Size);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
