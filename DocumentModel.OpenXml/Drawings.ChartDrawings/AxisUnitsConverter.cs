namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class converter from/to OpenXml.
///</summary>
public static class AxisUnitsConverter
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.AxisUnit? GetUnit(DXO2016DrawChartDraw.AxisUnits openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDrawsChartDraws.AxisUnit>(openXmlElement?.Unit?.Value);
  }
  
  private static bool CmpUnit(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.AxisUnit? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDrawsChartDraws.AxisUnit>(openXmlElement?.Unit?.Value, value, diffs, objName);
  }
  
  private static void SetUnit(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.AxisUnit? value)
  {
    openXmlElement.Unit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDrawsChartDraws.AxisUnit>(value);
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  private static DMDrawsChartDraws.AxisUnitsLabel? GetAxisUnitsLabel(DXO2016DrawChartDraw.AxisUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.AxisUnitsLabel>();
    if (element != null)
      return DMXDrawsChartDraws.AxisUnitsLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisUnitsLabel(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.AxisUnitsLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.AxisUnitsLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.AxisUnitsLabel>(), value, diffs, objName);
  }
  
  private static void SetAxisUnitsLabel(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.AxisUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.AxisUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.AxisUnitsLabelConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.AxisUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.AxisUnits openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.AxisUnits? CreateModelElement(DXO2016DrawChartDraw.AxisUnits? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.AxisUnits? openXmlElement, DMDrawsChartDraws.AxisUnits? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.AxisUnits value)
    where OpenXmlElementType: DXO2016DrawChartDraw.AxisUnits, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.AxisUnits openXmlElement, DMDrawsChartDraws.AxisUnits value)
  {
    SetUnit(openXmlElement, value?.Unit);
    SetAxisUnitsLabel(openXmlElement, value?.AxisUnitsLabel);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
