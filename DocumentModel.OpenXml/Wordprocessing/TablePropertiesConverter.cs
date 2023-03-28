namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Properties converter from/to OpenXml.
///</summary>
public static class TablePropertiesConverter
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  private static String? GetTableStyle(DXW.TableProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TableStyle>()?.Val);
  }
  
  private static bool CmpTableStyle(DXW.TableProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TableStyle>()?.Val, value, diffs, objName, "TableStyle");
  }
  
  private static void SetTableStyle(DXW.TableProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.TableStyle>(openXmlElement, value);
  }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  private static DMW.TablePositionProperties? GetTablePositionProperties(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePositionProperties>();
    if (element != null)
      return DMXW.TablePositionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTablePositionProperties(DXW.TableProperties openXmlElement, DMW.TablePositionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePositionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePositionProperties>(), value, diffs, objName);
  }
  
  private static void SetTablePositionProperties(DXW.TableProperties openXmlElement, DMW.TablePositionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePositionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePositionPropertiesConverter.CreateOpenXmlElement<DXW.TablePositionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  private static DMW.TableOverlapKind? GetTableOverlap(DXW.TableProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(openXmlElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value);
  }
  
  private static bool CmpTableOverlap(DXW.TableProperties openXmlElement, DMW.TableOverlapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(openXmlElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableOverlap(DXW.TableProperties openXmlElement, DMW.TableOverlapKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableOverlap>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(itemElement, (DMW.TableOverlapKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableOverlap, DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>((DMW.TableOverlapKind)value));
  }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  private static Boolean GetBiDiVisual(DXW.TableProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDiVisual>());
  }
  
  private static bool CmpBiDiVisual(DXW.TableProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDiVisual>(), value, diffs, objName);
  }
  
  private static void SetBiDiVisual(DXW.TableProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.BiDiVisual>(openXmlElement, value);
  }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  private static DMW.TableWidthType? GetTableWidth(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableWidth>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableWidth(DXW.TableProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableWidth>(), value, diffs, objName);
  }
  
  private static void SetTableWidth(DXW.TableProperties openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.TableProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.TableProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableJustification(DXW.TableProperties openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.TableProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }
  
  private static void SetTableCellSpacing(DXW.TableProperties openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  private static DMW.TableIndentation? GetTableIndentation(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (element != null)
      return DMXW.TableIndentationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableIndentation(DXW.TableProperties openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName);
  }
  
  private static void SetTableIndentation(DXW.TableProperties openXmlElement, DMW.TableIndentation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableIndentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableIndentationConverter.CreateOpenXmlElement<DXW.TableIndentation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  private static DMW.TableBorders? GetTableBorders(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (element != null)
      return DMXW.TableBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableBorders(DXW.TableProperties openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableBorders>(), value, diffs, objName);
  }
  
  private static void SetTableBorders(DXW.TableProperties openXmlElement, DMW.TableBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableBordersConverter.CreateOpenXmlElement<DXW.TableBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.TableProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }
  
  private static void SetShading(DXW.TableProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableLayout.
  /// </summary>
  private static DMW.TableLayout? GetTableLayout(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLayout>();
    if (element != null)
      return DMXW.TableLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableLayout(DXW.TableProperties openXmlElement, DMW.TableLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLayout>(), value, diffs, objName);
  }
  
  private static void SetTableLayout(DXW.TableProperties openXmlElement, DMW.TableLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableLayoutConverter.CreateOpenXmlElement<DXW.TableLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  private static DMW.TableCellMarginDefault? GetTableCellMarginDefault(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (element != null)
      return DMXW.TableCellMarginDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMarginDefault(DXW.TableProperties openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName);
  }
  
  private static void SetTableCellMarginDefault(DXW.TableProperties openXmlElement, DMW.TableCellMarginDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginDefaultConverter.CreateOpenXmlElement<DXW.TableCellMarginDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableLook.
  /// </summary>
  private static DMW.TableLook? GetTableLook(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLook>();
    if (element != null)
      return DMXW.TableLookConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableLook(DXW.TableProperties openXmlElement, DMW.TableLook? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLookConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLook>(), value, diffs, objName);
  }
  
  private static void SetTableLook(DXW.TableProperties openXmlElement, DMW.TableLook? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableLook>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableLookConverter.CreateOpenXmlElement<DXW.TableLook>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetTableCaption(DXW.TableProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TableCaption>()?.Val?.Value;
  }
  
  private static bool CmpTableCaption(DXW.TableProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCaption>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "TableCaption", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTableCaption(DXW.TableProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCaption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TableCaption { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetTableDescription(DXW.TableProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TableDescription>()?.Val?.Value;
  }
  
  private static bool CmpTableDescription(DXW.TableProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableDescription>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "TableDescription", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTableDescription(DXW.TableProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableDescription>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TableDescription { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Revision Information for Table Properties.
  /// </summary>
  private static DMW.TablePropertiesChange? GetTablePropertiesChange(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePropertiesChange>();
    if (element != null)
      return DMXW.TablePropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTablePropertiesChange(DXW.TableProperties openXmlElement, DMW.TablePropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePropertiesChange>(), value, diffs, objName);
  }
  
  private static void SetTablePropertiesChange(DXW.TableProperties openXmlElement, DMW.TablePropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertiesChangeConverter.CreateOpenXmlElement<DXW.TablePropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableProperties? CreateModelElement(DXW.TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableProperties();
      value.TableStyle = GetTableStyle(openXmlElement);
      value.TablePositionProperties = GetTablePositionProperties(openXmlElement);
      value.TableOverlap = GetTableOverlap(openXmlElement);
      value.BiDiVisual = GetBiDiVisual(openXmlElement);
      value.TableWidth = GetTableWidth(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableLayout = GetTableLayout(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      value.TableLook = GetTableLook(openXmlElement);
      value.TableCaption = GetTableCaption(openXmlElement);
      value.TableDescription = GetTableDescription(openXmlElement);
      value.TablePropertiesChange = GetTablePropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableProperties? openXmlElement, DMW.TableProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableStyle(openXmlElement, value.TableStyle, diffs, objName))
        ok = false;
      if (!CmpTablePositionProperties(openXmlElement, value.TablePositionProperties, diffs, objName))
        ok = false;
      if (!CmpTableOverlap(openXmlElement, value.TableOverlap, diffs, objName))
        ok = false;
      if (!CmpBiDiVisual(openXmlElement, value.BiDiVisual, diffs, objName))
        ok = false;
      if (!CmpTableWidth(openXmlElement, value.TableWidth, diffs, objName))
        ok = false;
      if (!CmpTableJustification(openXmlElement, value.TableJustification, diffs, objName))
        ok = false;
      if (!CmpTableCellSpacing(openXmlElement, value.TableCellSpacing, diffs, objName))
        ok = false;
      if (!CmpTableIndentation(openXmlElement, value.TableIndentation, diffs, objName))
        ok = false;
      if (!CmpTableBorders(openXmlElement, value.TableBorders, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpTableLayout(openXmlElement, value.TableLayout, diffs, objName))
        ok = false;
      if (!CmpTableCellMarginDefault(openXmlElement, value.TableCellMarginDefault, diffs, objName))
        ok = false;
      if (!CmpTableLook(openXmlElement, value.TableLook, diffs, objName))
        ok = false;
      if (!CmpTableCaption(openXmlElement, value.TableCaption, diffs, objName))
        ok = false;
      if (!CmpTableDescription(openXmlElement, value.TableDescription, diffs, objName))
        ok = false;
      if (!CmpTablePropertiesChange(openXmlElement, value.TablePropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableProperties value)
    where OpenXmlElementType: DXW.TableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableProperties openXmlElement, DMW.TableProperties value)
  {
    SetTableStyle(openXmlElement, value?.TableStyle);
    SetTablePositionProperties(openXmlElement, value?.TablePositionProperties);
    SetTableOverlap(openXmlElement, value?.TableOverlap);
    SetBiDiVisual(openXmlElement, value?.BiDiVisual);
    SetTableWidth(openXmlElement, value?.TableWidth);
    SetTableJustification(openXmlElement, value?.TableJustification);
    SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
    SetTableIndentation(openXmlElement, value?.TableIndentation);
    SetTableBorders(openXmlElement, value?.TableBorders);
    SetShading(openXmlElement, value?.Shading);
    SetTableLayout(openXmlElement, value?.TableLayout);
    SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
    SetTableLook(openXmlElement, value?.TableLook);
    SetTableCaption(openXmlElement, value?.TableCaption);
    SetTableDescription(openXmlElement, value?.TableDescription);
    SetTablePropertiesChange(openXmlElement, value?.TablePropertiesChange);
  }
}
