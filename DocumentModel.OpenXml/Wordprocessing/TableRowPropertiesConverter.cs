namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public static class TableRowPropertiesConverter
{
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DXW.TableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      return DMXW.ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DivId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridBefore>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.GridAfter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.WidthAfterTableRow>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableRowHeight>();
    if (itemElement != null)
      return DMXW.TableRowHeightConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.Hidden>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
  
  private static DMW.OnOffOnlyKind? GetCantSplit(DXW.TableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetCantSplit(DXW.TableRowProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.CantSplit, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.OnOffOnlyKind? GetTableHeader(DXW.TableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableHeader(DXW.TableRowProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableHeader, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.TableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Deleted>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableRowPropertiesChange>();
    if (itemElement != null)
      return DMXW.TableRowPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (itemElement != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
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
