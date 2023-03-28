namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Properties.
/// </summary>
public static class PreviousTablePropertiesConverter
{
  /// <summary>
  /// TableStyle.
  /// </summary>
  private static String? GetTableStyle(DXW.PreviousTableProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TableStyle>()?.Val);
  }
  
  private static bool CmpTableStyle(DXW.PreviousTableProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TableStyle>()?.Val, value, diffs, objName, "TableStyle");
  }
  
  private static void SetTableStyle(DXW.PreviousTableProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.TableStyle>(openXmlElement, value);
  }
  
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  private static DMW.TablePositionProperties? GetTablePositionProperties(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePositionProperties>();
    if (element != null)
      return DMXW.TablePositionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTablePositionProperties(DXW.PreviousTableProperties openXmlElement, DMW.TablePositionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePositionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePositionProperties>(), value, diffs, objName);
  }
  
  private static void SetTablePositionProperties(DXW.PreviousTableProperties openXmlElement, DMW.TablePositionProperties? value)
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
  private static DMW.TableOverlapKind? GetTableOverlap(DXW.PreviousTableProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(openXmlElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value);
  }
  
  private static bool CmpTableOverlap(DXW.PreviousTableProperties openXmlElement, DMW.TableOverlapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(openXmlElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableOverlap(DXW.PreviousTableProperties openXmlElement, DMW.TableOverlapKind? value)
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
  private static Boolean GetBiDiVisual(DXW.PreviousTableProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDiVisual>());
  }
  
  private static bool CmpBiDiVisual(DXW.PreviousTableProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDiVisual>(), value, diffs, objName);
  }
  
  private static void SetBiDiVisual(DXW.PreviousTableProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.BiDiVisual>(openXmlElement, value);
  }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  private static DMW.TableWidthType? GetTableWidth(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableWidth>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableWidth(DXW.PreviousTableProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableWidth>(), value, diffs, objName);
  }
  
  private static void SetTableWidth(DXW.PreviousTableProperties openXmlElement, DMW.TableWidthType? value)
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
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.PreviousTableProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.PreviousTableProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableJustification(DXW.PreviousTableProperties openXmlElement, DMW.TableRowAlignmentKind? value)
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
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.PreviousTableProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }
  
  private static void SetTableCellSpacing(DXW.PreviousTableProperties openXmlElement, DMW.TableWidthType? value)
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
  private static DMW.TableIndentation? GetTableIndentation(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (element != null)
      return DMXW.TableIndentationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableIndentation(DXW.PreviousTableProperties openXmlElement, DMW.TableIndentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName);
  }
  
  private static void SetTableIndentation(DXW.PreviousTableProperties openXmlElement, DMW.TableIndentation? value)
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
  private static DMW.TableBorders? GetTableBorders(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (element != null)
      return DMXW.TableBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableBorders(DXW.PreviousTableProperties openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableBorders>(), value, diffs, objName);
  }
  
  private static void SetTableBorders(DXW.PreviousTableProperties openXmlElement, DMW.TableBorders? value)
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
  private static DMW.Shading? GetShading(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.PreviousTableProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }
  
  private static void SetShading(DXW.PreviousTableProperties openXmlElement, DMW.Shading? value)
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
  private static DMW.TableLayout? GetTableLayout(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLayout>();
    if (element != null)
      return DMXW.TableLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableLayout(DXW.PreviousTableProperties openXmlElement, DMW.TableLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLayout>(), value, diffs, objName);
  }
  
  private static void SetTableLayout(DXW.PreviousTableProperties openXmlElement, DMW.TableLayout? value)
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
  private static DMW.TableCellMarginDefault? GetTableCellMarginDefault(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (element != null)
      return DMXW.TableCellMarginDefaultConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMarginDefault(DXW.PreviousTableProperties openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginDefaultConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName);
  }
  
  private static void SetTableCellMarginDefault(DXW.PreviousTableProperties openXmlElement, DMW.TableCellMarginDefault? value)
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
  private static DMW.TableLook? GetTableLook(DXW.PreviousTableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLook>();
    if (element != null)
      return DMXW.TableLookConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableLook(DXW.PreviousTableProperties openXmlElement, DMW.TableLook? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLookConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLook>(), value, diffs, objName);
  }
  
  private static void SetTableLook(DXW.PreviousTableProperties openXmlElement, DMW.TableLook? value)
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
  private static String? GetTableCaption(DXW.PreviousTableProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TableCaption>()?.Val?.Value;
  }
  
  private static bool CmpTableCaption(DXW.PreviousTableProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCaption>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "TableCaption", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTableCaption(DXW.PreviousTableProperties openXmlElement, String? value)
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
  private static String? GetTableDescription(DXW.PreviousTableProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TableDescription>()?.Val?.Value;
  }
  
  private static bool CmpTableDescription(DXW.PreviousTableProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableDescription>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "TableDescription", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTableDescription(DXW.PreviousTableProperties openXmlElement, String? value)
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
  
  public static DMW.PreviousTableProperties? CreateModelElement(DXW.PreviousTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTableProperties();
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
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableProperties? openXmlElement, DMW.PreviousTableProperties? value, DiffList? diffs, string? objName)
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableProperties value)
    where OpenXmlElementType: DXW.PreviousTableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableProperties openXmlElement, DMW.PreviousTableProperties value)
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
  }
}
