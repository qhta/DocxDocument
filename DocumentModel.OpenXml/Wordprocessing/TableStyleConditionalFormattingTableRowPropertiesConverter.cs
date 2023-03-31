namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableRowPropertiesConverter
{
  private static Boolean? GetHidden(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Hidden>());
  }
  
  private static bool CmpHidden(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Hidden>(), value, diffs, objName);
  }
  
  private static void SetHidden(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Hidden>(openXmlElement, value);
  }
  
  private static Boolean GetCantSplit(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.CantSplit>());
  }
  
  private static bool CmpCantSplit(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CantSplit>(), value, diffs, objName);
  }
  
  private static void SetCantSplit(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.CantSplit>(openXmlElement, value);
  }
  
  private static Boolean GetTableHeader(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TableHeader>());
  }
  
  private static bool CmpTableHeader(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableHeader>(), value, diffs, objName);
  }
  
  private static void SetTableHeader(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.TableHeader>(openXmlElement, value);
  }
  
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }
  
  private static void SetTableCellSpacing(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableWidthType? value)
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
  
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableJustification(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value)
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
  
  public static DMW.TableStyleConditionalRowProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableStyleConditionalRowProperties();
      value.Hidden = GetHidden(openXmlElement);
      value.CantSplit = GetCantSplit(openXmlElement);
      value.TableHeader = GetTableHeader(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleConditionalFormattingTableRowProperties? openXmlElement, DMW.TableStyleConditionalRowProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName))
        ok = false;
      if (!CmpCantSplit(openXmlElement, value.CantSplit, diffs, objName))
        ok = false;
      if (!CmpTableHeader(openXmlElement, value.TableHeader, diffs, objName))
        ok = false;
      if (!CmpTableCellSpacing(openXmlElement, value.TableCellSpacing, diffs, objName))
        ok = false;
      if (!CmpTableJustification(openXmlElement, value.TableJustification, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalRowProperties value)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableStyleConditionalRowProperties value)
  {
    SetHidden(openXmlElement, value?.Hidden);
    SetCantSplit(openXmlElement, value?.CantSplit);
    SetTableHeader(openXmlElement, value?.TableHeader);
    SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
    SetTableJustification(openXmlElement, value?.TableJustification);
  }
}
