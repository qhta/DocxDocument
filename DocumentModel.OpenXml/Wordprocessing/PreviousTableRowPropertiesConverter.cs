namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Row Properties.
/// </summary>
public static class PreviousTableRowPropertiesConverter
{
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DXW.PreviousTableRowProperties openXmlElement)
  {
    return DMXW.ConditionalFormatStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>());
  }
  
  private static bool CmpConditionalFormatStyle(DXW.PreviousTableRowProperties openXmlElement, DMW.ConditionalFormatStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConditionalFormatStyle(DXW.PreviousTableRowProperties openXmlElement, DMW.ConditionalFormatStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ConditionalFormatStyleConverter.CreateOpenXmlElement<DXW.ConditionalFormatStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDivId(DXW.PreviousTableRowProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DivId>()?.Val?.Value;
  }
  
  private static bool CmpDivId(DXW.PreviousTableRowProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DivId>()?.Val?.Value == value;
  }
  
  private static void SetDivId(DXW.PreviousTableRowProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DivId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DivId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGridBefore(DXW.PreviousTableRowProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val?.Value;
  }
  
  private static bool CmpGridBefore(DXW.PreviousTableRowProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridBefore>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.GridBefore", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGridBefore(DXW.PreviousTableRowProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.GridBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.GridBefore{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGridAfter(DXW.PreviousTableRowProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val?.Value;
  }
  
  private static bool CmpGridAfter(DXW.PreviousTableRowProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridAfter>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.GridAfter", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGridAfter(DXW.PreviousTableRowProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.GridAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.GridAfter{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableWidthType? GetWidthBeforeTableRow(DXW.PreviousTableRowProperties openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.WidthBeforeTableRow>());
  }
  
  private static bool CmpWidthBeforeTableRow(DXW.PreviousTableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWidthBeforeTableRow(DXW.PreviousTableRowProperties openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.WidthBeforeTableRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableWidthType? GetWidthAfterTableRow(DXW.PreviousTableRowProperties openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.WidthAfterTableRow>());
  }
  
  private static bool CmpWidthAfterTableRow(DXW.PreviousTableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWidthAfterTableRow(DXW.PreviousTableRowProperties openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.WidthAfterTableRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableRowHeight? GetTableRowHeight(DXW.PreviousTableRowProperties openXmlElement)
  {
    return DMXW.TableRowHeightConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableRowHeight>());
  }
  
  private static bool CmpTableRowHeight(DXW.PreviousTableRowProperties openXmlElement, DMW.TableRowHeight? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowHeightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowHeight>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableRowHeight(DXW.PreviousTableRowProperties openXmlElement, DMW.TableRowHeight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableRowHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableRowHeightConverter.CreateOpenXmlElement<DXW.TableRowHeight>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetHidden(DXW.PreviousTableRowProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Hidden>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpHidden(DXW.PreviousTableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetHidden(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Hidden", val, value);
    return false;
  }
  
  private static void SetHidden(DXW.PreviousTableRowProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Hidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Hidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetCantSplit(DXW.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpCantSplit(DXW.PreviousTableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CantSplit>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCantSplit(DXW.PreviousTableRowProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.CantSplit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTableHeader(DXW.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpTableHeader(DXW.PreviousTableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableHeader>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableHeader(DXW.PreviousTableRowProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TableHeader();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.PreviousTableRowProperties openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableCellSpacing>());
  }
  
  private static bool CmpTableCellSpacing(DXW.PreviousTableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellSpacing(DXW.PreviousTableRowProperties openXmlElement, DMW.TableWidthType? value)
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
  
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.PreviousTableRowProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.PreviousTableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableJustification(DXW.PreviousTableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.PreviousTableRowProperties? CreateModelElement(DXW.PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTableRowProperties();
      value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
      value.DivId = GetDivId(openXmlElement);
      value.GridBefore = GetGridBefore(openXmlElement);
      value.GridAfter = GetGridAfter(openXmlElement);
      value.WidthBeforeTableRow = GetWidthBeforeTableRow(openXmlElement);
      value.WidthAfterTableRow = GetWidthAfterTableRow(openXmlElement);
      value.TableRowHeight = GetTableRowHeight(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.CantSplit = GetCantSplit(openXmlElement);
      value.TableHeader = GetTableHeader(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableRowProperties? openXmlElement, DMW.PreviousTableRowProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConditionalFormatStyle(openXmlElement, value.ConditionalFormatStyle, diffs, objName))
        ok = false;
      if (!CmpDivId(openXmlElement, value.DivId, diffs, objName))
        ok = false;
      if (!CmpGridBefore(openXmlElement, value.GridBefore, diffs, objName))
        ok = false;
      if (!CmpGridAfter(openXmlElement, value.GridAfter, diffs, objName))
        ok = false;
      if (!CmpWidthBeforeTableRow(openXmlElement, value.WidthBeforeTableRow, diffs, objName))
        ok = false;
      if (!CmpWidthAfterTableRow(openXmlElement, value.WidthAfterTableRow, diffs, objName))
        ok = false;
      if (!CmpTableRowHeight(openXmlElement, value.TableRowHeight, diffs, objName))
        ok = false;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableRowProperties? value)
    where OpenXmlElementType: DXW.PreviousTableRowProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
      SetDivId(openXmlElement, value?.DivId);
      SetGridBefore(openXmlElement, value?.GridBefore);
      SetGridAfter(openXmlElement, value?.GridAfter);
      SetWidthBeforeTableRow(openXmlElement, value?.WidthBeforeTableRow);
      SetWidthAfterTableRow(openXmlElement, value?.WidthAfterTableRow);
      SetTableRowHeight(openXmlElement, value?.TableRowHeight);
      SetHidden(openXmlElement, value?.Hidden);
      SetCantSplit(openXmlElement, value?.CantSplit);
      SetTableHeader(openXmlElement, value?.TableHeader);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableJustification(openXmlElement, value?.TableJustification);
      return openXmlElement;
    }
    return default;
  }
}
