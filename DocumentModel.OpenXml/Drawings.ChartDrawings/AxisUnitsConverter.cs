namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public static class AxisUnitsConverter
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.AxisUnit? GetUnit(DXO16DCD.AxisUnits openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDCDs.AxisUnit>(openXmlElement?.Unit?.Value);
  }
  
  private static bool CmpUnit(DXO16DCD.AxisUnits openXmlElement, DMDCDs.AxisUnit? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDCDs.AxisUnit>(openXmlElement?.Unit?.Value, value, diffs, objName);
  }
  
  private static void SetUnit(DXO16DCD.AxisUnits openXmlElement, DMDCDs.AxisUnit? value)
  {
    openXmlElement.Unit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDCDs.AxisUnit>(value);
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  private static DMDCDs.AxisUnitsLabel? GetAxisUnitsLabel(DXO16DCD.AxisUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.AxisUnitsLabel>();
    if (element != null)
      return DMXDCDs.AxisUnitsLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisUnitsLabel(DXO16DCD.AxisUnits openXmlElement, DMDCDs.AxisUnitsLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.AxisUnitsLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.AxisUnitsLabel>(), value, diffs, objName);
  }
  
  private static void SetAxisUnitsLabel(DXO16DCD.AxisUnits openXmlElement, DMDCDs.AxisUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.AxisUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.AxisUnitsLabelConverter.CreateOpenXmlElement<DXO16DCD.AxisUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.AxisUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.AxisUnits openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.AxisUnits openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.AxisUnits? CreateModelElement(DXO16DCD.AxisUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.AxisUnits();
      value.Unit = GetUnit(openXmlElement);
      value.AxisUnitsLabel = GetAxisUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.AxisUnits? openXmlElement, DMDCDs.AxisUnits? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnit(openXmlElement, value.Unit, diffs, objName))
        ok = false;
      if (!CmpAxisUnitsLabel(openXmlElement, value.AxisUnitsLabel, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.AxisUnits value)
    where OpenXmlElementType: DXO16DCD.AxisUnits, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.AxisUnits openXmlElement, DMDCDs.AxisUnits value)
  {
    SetUnit(openXmlElement, value?.Unit);
    SetAxisUnitsLabel(openXmlElement, value?.AxisUnitsLabel);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
