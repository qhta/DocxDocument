using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ConditionalFormatStyle = DocumentModel.Wordprocessing.ConditionalFormatStyle;
using TableRowHeight = DocumentModel.Wordprocessing.TableRowHeight;
using TableRowProperties = DocumentFormat.OpenXml.Wordprocessing.TableRowProperties;
using TableRowPropertiesChange = DocumentModel.Wordprocessing.TableRowPropertiesChange;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Table Row Properties.
/// </summary>
public static class TableRowPropertiesConverter
{
  public static ConditionalFormatStyle? GetConditionalFormatStyle(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      return ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConditionalFormatStyle(TableRowProperties? openXmlElement, ConditionalFormatStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConditionalFormatStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetDivId(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DivId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDivId(TableRowProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DivId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DivId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetGridBefore(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GridBefore>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGridBefore(TableRowProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GridBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GridBefore { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetGridAfter(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GridAfter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGridAfter(TableRowProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GridAfter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GridAfter { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TableWidthType? GetWidthBeforeTableRow(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WidthBeforeTableRow>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWidthBeforeTableRow(TableRowProperties? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidthBeforeTableRow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<WidthBeforeTableRow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TableWidthType? GetWidthAfterTableRow(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WidthAfterTableRow>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWidthAfterTableRow(TableRowProperties? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidthAfterTableRow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<WidthAfterTableRow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TableRowHeight? GetTableRowHeight(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>();
    if (itemElement != null)
      return TableRowHeightConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableRowHeight(TableRowProperties? openXmlElement, TableRowHeight? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableRowHeightConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetHidden(TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Hidden>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetHidden(TableRowProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Hidden>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Hidden();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OnOffOnlyKind? GetCantSplit(TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CantSplit>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCantSplit(TableRowProperties? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CantSplit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<CantSplit, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OnOffOnlyKind? GetTableHeader(TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableHeader>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableHeader(TableRowProperties? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TableHeader, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TableWidthType? GetTableCellSpacing(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellSpacing>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellSpacing(TableRowProperties? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCellSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<TableCellSpacing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TableRowAlignmentKind? GetTableJustification(TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableRowAlignmentValues, TableRowAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableJustification(TableRowProperties? openXmlElement, TableRowAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TableJustification, TableRowAlignmentValues, TableRowAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetInserted(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Inserted>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInserted(TableRowProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Inserted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<Inserted>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetDeleted(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Deleted>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeleted(TableRowProperties? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Deleted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<Deleted>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TableRowPropertiesChange? GetTableRowPropertiesChange(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange>();
    if (itemElement != null)
      return TableRowPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableRowPropertiesChange(TableRowProperties? openXmlElement, TableRowPropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableRowPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetConflictInsertion(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ConflictInsertion>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConflictInsertion(TableRowProperties? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConflictInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<ConflictInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetConflictDeletion(TableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ConflictDeletion>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConflictDeletion(TableRowProperties? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConflictDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<ConflictDeletion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableRowProperties? CreateModelElement(TableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableRowProperties();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableRowProperties? value)
    where OpenXmlElementType : TableRowProperties, new()
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