namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableCellPropertiesConverter
{
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  private static DMW.TableCellBorders? GetTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellBorders>();
    if (element != null)
      return DMXW.TableCellBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellBordersConverter.CreateOpenXmlElement<DXW.TableCellBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.Shading? value)
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
  /// NoWrap.
  /// </summary>
  private static Boolean GetNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoWrap>());
  }
  
  private static bool CmpNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoWrap>(), value, diffs, objName);
  }
  
  private static void SetNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.NoWrap>(openXmlElement, value);
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  private static DMW.TableCellMargin? GetTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMargin>();
    if (element != null)
      return DMXW.TableCellMarginConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMargin>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
  }
  
  private static bool CmpTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement, (DMW.TableVerticalAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>((DMW.TableVerticalAlignmentKind)value));
  }
  
  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties();
      value.TableCellBorders = GetTableCellBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleConditionalFormattingTableCellProperties? openXmlElement, DMW.TableStyleConditionalFormattingTableCellProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableCellBorders(openXmlElement, value.TableCellBorders, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpNoWrap(openXmlElement, value.NoWrap, diffs, objName))
        ok = false;
      if (!CmpTableCellMargin(openXmlElement, value.TableCellMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellVerticalAlignment(openXmlElement, value.TableCellVerticalAlignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalFormattingTableCellProperties value)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableStyleConditionalFormattingTableCellProperties value)
  {
    SetTableCellBorders(openXmlElement, value?.TableCellBorders);
    SetShading(openXmlElement, value?.Shading);
    SetNoWrap(openXmlElement, value?.NoWrap);
    SetTableCellMargin(openXmlElement, value?.TableCellMargin);
    SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
  }
}
