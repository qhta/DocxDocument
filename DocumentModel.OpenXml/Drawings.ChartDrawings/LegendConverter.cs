namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Legend Class.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.SidePos? GetPos(DXO2016DrawChartDraw.Legend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDrawsChartDraws.SidePos>(openXmlElement?.Pos?.Value);
  }
  
  private static bool CmpPos(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.SidePos? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDrawsChartDraws.SidePos>(openXmlElement?.Pos?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPos(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.SidePos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDrawsChartDraws.SidePos>(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.PosAlign? GetAlign(DXO2016DrawChartDraw.Legend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDrawsChartDraws.PosAlign>(openXmlElement?.Align?.Value);
  }
  
  private static bool CmpAlign(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.PosAlign? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDrawsChartDraws.PosAlign>(openXmlElement?.Align?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlign(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.PosAlign? value)
  {
    openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDrawsChartDraws.PosAlign>(value);
  }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetOverlay(DXO2016DrawChartDraw.Legend openXmlElement)
  {
    return openXmlElement?.Overlay?.Value;
  }
  
  private static bool CmpOverlay(DXO2016DrawChartDraw.Legend openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Overlay?.Value == value) return true;
    diffs?.Add(objName, "Overlay", openXmlElement?.Overlay?.Value, value);
    return false;
  }
  
  private static void SetOverlay(DXO2016DrawChartDraw.Legend openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Overlay = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Overlay = null;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.Legend openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
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
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.Legend openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (element != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
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
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.Legend openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.Legend? CreateModelElement(DXO2016DrawChartDraw.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Legend();
      value.Pos = GetPos(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Legend? openXmlElement, DMDrawsChartDraws.Legend? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPos(openXmlElement, value.Pos, diffs, objName))
        ok = false;
      if (!CmpAlign(openXmlElement, value.Align, diffs, objName))
        ok = false;
      if (!CmpOverlay(openXmlElement, value.Overlay, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTxPrTextBody(openXmlElement, value.TxPrTextBody, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Legend value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Legend, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Legend openXmlElement, DMDrawsChartDraws.Legend value)
  {
    SetPos(openXmlElement, value?.Pos);
    SetAlign(openXmlElement, value?.Align);
    SetOverlay(openXmlElement, value?.Overlay);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
