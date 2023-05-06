namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartTitle Class.
/// </summary>
public static class ChartTitleConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.SidePos? GetPos(DXO16DCD.ChartTitle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDCDs.SidePos>(openXmlElement?.Pos?.Value);
  }
  
  private static bool CmpPos(DXO16DCD.ChartTitle openXmlElement, DMDCDs.SidePos? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDCDs.SidePos>(openXmlElement?.Pos?.Value, value, diffs, objName);
  }
  
  private static void SetPos(DXO16DCD.ChartTitle openXmlElement, DMDCDs.SidePos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDCDs.SidePos>(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.PosAlign? GetAlign(DXO16DCD.ChartTitle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDCDs.PosAlign>(openXmlElement?.Align?.Value);
  }
  
  private static bool CmpAlign(DXO16DCD.ChartTitle openXmlElement, DMDCDs.PosAlign? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDCDs.PosAlign>(openXmlElement?.Align?.Value, value, diffs, objName);
  }
  
  private static void SetAlign(DXO16DCD.ChartTitle openXmlElement, DMDCDs.PosAlign? value)
  {
    openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDCDs.PosAlign>(value);
  }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetOverlay(DXO16DCD.ChartTitle openXmlElement)
  {
    return openXmlElement?.Overlay?.Value;
  }
  
  private static bool CmpOverlay(DXO16DCD.ChartTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Overlay?.Value == value) return true;
    diffs?.Add(objName, "Overlay", openXmlElement?.Overlay?.Value, value);
    return false;
  }
  
  private static void SetOverlay(DXO16DCD.ChartTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Overlay = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Overlay = null;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static DMDCDs.Text? GetText(DXO16DCD.ChartTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Text>();
    if (element != null)
      return DMXDCDs.TextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpText(DXO16DCD.ChartTitle openXmlElement, DMDCDs.Text? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.TextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Text>(), value, diffs, objName);
  }
  
  private static void SetText(DXO16DCD.ChartTitle openXmlElement, DMDCDs.Text? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.TextConverter.CreateOpenXmlElement<DXO16DCD.Text>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.ChartTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.ChartTitle openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO16DCD.ChartTitle openXmlElement, DMDCDs.ShapeProperties? value)
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
  private static DMDCDs.TxPrTextBody? GetTxPrTextBody(DXO16DCD.ChartTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (element != null)
      return DMXDCDs.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO16DCD.ChartTitle openXmlElement, DMDCDs.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>(), value, diffs, objName);
  }
  
  private static void SetTxPrTextBody(DXO16DCD.ChartTitle openXmlElement, DMDCDs.TxPrTextBody? value)
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
  /// ExtensionList.
  /// </summary>
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.ChartTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.ChartTitle openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.ChartTitle openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.ChartTitle? CreateModelElement(DXO16DCD.ChartTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartTitle();
      value.Pos = GetPos(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.Text = GetText(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ChartTitle? openXmlElement, DMDCDs.ChartTitle? value, DiffList? diffs, string? objName)
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
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ChartTitle value)
    where OpenXmlElementType: DXO16DCD.ChartTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ChartTitle openXmlElement, DMDCDs.ChartTitle value)
  {
    SetPos(openXmlElement, value?.Pos);
    SetAlign(openXmlElement, value?.Align);
    SetOverlay(openXmlElement, value?.Overlay);
    SetText(openXmlElement, value?.Text);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
