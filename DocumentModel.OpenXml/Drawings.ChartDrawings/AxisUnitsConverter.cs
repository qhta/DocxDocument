namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public static class AxisUnitsConverter
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.AxisUnit? GetUnit(DXO2016DrawChartDraw.AxisUnits openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DMDrawsChartDraws.AxisUnit>(openXmlElement?.Unit?.Value);
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.AxisUnitsLabel>();
    if (itemElement != null)
      return DMXDrawsChartDraws.AxisUnitsLabelConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraws.AxisUnits? CreateModelElement(DXO2016DrawChartDraw.AxisUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.AxisUnits();
      value.Unit = GetUnit(openXmlElement);
      value.AxisUnitsLabel = GetAxisUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.AxisUnits? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.AxisUnits, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnit(openXmlElement, value?.Unit);
      SetAxisUnitsLabel(openXmlElement, value?.AxisUnitsLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
