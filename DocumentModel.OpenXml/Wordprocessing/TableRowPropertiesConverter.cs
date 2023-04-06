namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public static class TableRowPropertiesConverter
{
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (element != null)
      return DMXW.ConditionalFormatStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConditionalFormatStyle(DXW.TableRowProperties openXmlElement, DMW.ConditionalFormatStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName);
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
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val);
  }
  
  private static bool CmpDivId(DXW.TableRowProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val, value, diffs, objName, "DivId");
  }
  
  private static void SetDivId(DXW.TableRowProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DivId>(openXmlElement, value);
  }
  
  private static Int32? GetGridBefore(DXW.TableRowProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val);
  }
  
  private static bool CmpGridBefore(DXW.TableRowProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val, value, diffs, objName, "GridBefore");
  }
  
  private static void SetGridBefore(DXW.TableRowProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridBefore,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGridAfter(DXW.TableRowProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val);
  }
  
  private static bool CmpGridAfter(DXW.TableRowProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val, value, diffs, objName, "GridAfter");
  }
  
  private static void SetGridAfter(DXW.TableRowProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridAfter,System.Int32>(openXmlElement, value);
  }
  
  private static DMW.TableWidth? GetWidthBeforeTableRow(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWidthBeforeTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>(), value, diffs, objName);
  }
  
  private static void SetWidthBeforeTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidth? value)
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
  
  private static DMW.TableWidth? GetWidthAfterTableRow(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WidthAfterTableRow>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWidthAfterTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>(), value, diffs, objName);
  }
  
  private static void SetWidthAfterTableRow(DXW.TableRowProperties openXmlElement, DMW.TableWidth? value)
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
    var element = openXmlElement?.GetFirstChild<DXW.TableRowHeight>();
    if (element != null)
      return DMXW.TableRowHeightConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableRowHeight(DXW.TableRowProperties openXmlElement, DMW.TableRowHeight? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowHeightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowHeight>(), value, diffs, objName);
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
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Hidden>());
  }
  
  private static bool CmpHidden(DXW.TableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Hidden>(), value, diffs, objName);
  }
  
  private static void SetHidden(DXW.TableRowProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Hidden>(openXmlElement, value);
  }
  
  private static Boolean GetCantSplit(DXW.TableRowProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.CantSplit>());
  }
  
  private static bool CmpCantSplit(DXW.TableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CantSplit>(), value, diffs, objName);
  }
  
  private static void SetCantSplit(DXW.TableRowProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.CantSplit>(openXmlElement, value);
  }
  
  private static Boolean GetTableHeader(DXW.TableRowProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TableHeader>());
  }
  
  private static bool CmpTableHeader(DXW.TableRowProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableHeader>(), value, diffs, objName);
  }
  
  private static void SetTableHeader(DXW.TableRowProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.TableHeader>(openXmlElement, value);
  }
  
  private static DMW.TableWidth? GetTableCellSpacing(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellSpacing(DXW.TableRowProperties openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }
  
  private static void SetTableCellSpacing(DXW.TableRowProperties openXmlElement, DMW.TableWidth? value)
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableJustification(DXW.TableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value)
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
  
  private static DMW.TrackChangeType? GetInserted(DXW.TableRowProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInserted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.Deleted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeleted(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Deleted>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.TableRowPropertiesChange>();
    if (element != null)
      return DMXW.TableRowPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableRowPropertiesChange(DXW.TableRowProperties openXmlElement, DMW.TableRowPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowPropertiesChange>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictInsertion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictDeletion(DXW.TableRowProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>(), value, diffs, objName);
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowProperties value)
    where OpenXmlElementType: DXW.TableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowProperties openXmlElement, DMW.TableRowProperties value)
  {
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
  }
}
