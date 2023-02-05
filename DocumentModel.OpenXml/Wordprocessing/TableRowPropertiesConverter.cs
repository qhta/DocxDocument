namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public static class TableRowPropertiesConverter
{
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.ConditionalFormatStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>());
  }
  
  private static bool CmpConditionalFormatStyle(DXW.TableRowProperties openXmlElement, DMW.ConditionalFormatStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConditionalFormatStyle(DXW.TableRowProperties openXmlElement, DMW.ConditionalFormatStyle? value)
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
  
  private static String? GetDivId(DXW.TableRowProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DivId>()?.Val?.Value;
  }
  
  private static bool CmpDivId(DXW.TableRowProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DivId>()?.Val?.Value == value;
  }
  
  private static void SetDivId(DXW.TableRowProperties openXmlElement, String? value)
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
  
  private static Int32? GetGridBefore(DXW.TableRowProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val?.Value;
  }
  
  private static bool CmpGridBefore(DXW.TableRowProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridBefore>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.GridBefore", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGridBefore(DXW.TableRowProperties openXmlElement, Int32? value)
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
  
  private static Int32? GetGridAfter(DXW.TableRowProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val?.Value;
  }
  
  private static bool CmpGridAfter(DXW.TableRowProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridAfter>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.GridAfter", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGridAfter(DXW.TableRowProperties openXmlElement, Int32? value)
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
  
  private static DMW.TableWidthType? GetWidthBeforeTableRow(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.WidthBeforeTableRow>());
  }
  
  private static bool CmpWidthBeforeTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWidthBeforeTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidthType? value)
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
  
  private static DMW.TableWidthType? GetWidthAfterTableRow(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.WidthAfterTableRow>());
  }
  
  private static bool CmpWidthAfterTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWidthAfterTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidthType? value)
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
  
  private static DMW.TableRowHeight? GetTableRowHeight(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TableRowHeightConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableRowHeight>());
  }
  
  private static bool CmpTableRowHeight(DXW.TableRowProperties openXmlElement, DMW.TableRowHeight? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowHeightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowHeight>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableRowHeight(DXW.TableRowProperties openXmlElement, DMW.TableRowHeight? value)
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
  
  private static Boolean? GetHidden(DXW.TableRowProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Hidden>()?.Val?.Value;
  }
  
  private static bool CmpHidden(DXW.TableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.Hidden>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Hidden", val, value);
    return false;
  }
  
  private static void SetHidden(DXW.TableRowProperties openXmlElement, Boolean? value)
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
  
  private static Boolean? GetCantSplit(DXW.TableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpCantSplit(DXW.TableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CantSplit>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCantSplit(DXW.TableRowProperties openXmlElement, Boolean? value)
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
  
  private static Boolean? GetTableHeader(DXW.TableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value == DXW.OnOffOnlyValues.On;
    return null;
  }
  
  private static bool CmpTableHeader(DXW.TableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableHeader>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableHeader(DXW.TableRowProperties openXmlElement, Boolean? value)
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
  
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TableWidthTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableCellSpacing>());
  }
  
  private static bool CmpTableCellSpacing(DXW.TableRowProperties openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableCellSpacing(DXW.TableRowProperties openXmlElement, DMW.TableWidthType? value)
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
  
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.TableRowProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }
  
  private static bool CmpTableJustification(DXW.TableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableJustification(DXW.TableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value)
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
  
  private static DMW.TrackChangeType? GetInserted(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Inserted>());
  }
  
  private static bool CmpInserted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInserted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Inserted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Inserted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetDeleted(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Deleted>());
  }
  
  private static bool CmpDeleted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Deleted>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeleted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Deleted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Deleted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableRowPropertiesChange? GetTableRowPropertiesChange(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TableRowPropertiesChangeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableRowPropertiesChange>());
  }
  
  private static bool CmpTableRowPropertiesChange(DXW.TableRowProperties openXmlElement, DMW.TableRowPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowPropertiesChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableRowPropertiesChange(DXW.TableRowProperties openXmlElement, DMW.TableRowPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableRowPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableRowPropertiesChangeConverter.CreateOpenXmlElement<DXW.TableRowPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetConflictInsertion(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.ConflictInsertion>());
  }
  
  private static bool CmpConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.ConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetConflictDeletion(DXW.TableRowProperties openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.ConflictDeletion>());
  }
  
  private static bool CmpConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.ConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableRowProperties? CreateModelElement(DXW.TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableRowProperties();
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
      value.Inserted = GetInserted(openXmlElement);
      value.Deleted = GetDeleted(openXmlElement);
      value.TableRowPropertiesChange = GetTableRowPropertiesChange(openXmlElement);
      value.ConflictInsertion = GetConflictInsertion(openXmlElement);
      value.ConflictDeletion = GetConflictDeletion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowProperties? openXmlElement, DMW.TableRowProperties? value, DiffList? diffs, string? objName)
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
      if (!CmpInserted(openXmlElement, value.Inserted, diffs, objName))
        ok = false;
      if (!CmpDeleted(openXmlElement, value.Deleted, diffs, objName))
        ok = false;
      if (!CmpTableRowPropertiesChange(openXmlElement, value.TableRowPropertiesChange, diffs, objName))
        ok = false;
      if (!CmpConflictInsertion(openXmlElement, value.ConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpConflictDeletion(openXmlElement, value.ConflictDeletion, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowProperties? value)
    where OpenXmlElementType: DXW.TableRowProperties, new()
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
      SetInserted(openXmlElement, value?.Inserted);
      SetDeleted(openXmlElement, value?.Deleted);
      SetTableRowPropertiesChange(openXmlElement, value?.TableRowPropertiesChange);
      SetConflictInsertion(openXmlElement, value?.ConflictInsertion);
      SetConflictDeletion(openXmlElement, value?.ConflictDeletion);
      return openXmlElement;
    }
    return default;
  }
}
