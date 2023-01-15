using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ConditionalFormatStyle = DocumentModel.Wordprocessing.ConditionalFormatStyle;
using PreviousTableRowProperties = DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties;
using TableRowHeight = DocumentModel.Wordprocessing.TableRowHeight;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Previous Table Row Properties.
/// </summary>
public static class PreviousTableRowPropertiesConverter
{
  public static ConditionalFormatStyle? GetConditionalFormatStyle(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      return ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConditionalFormatStyle(PreviousTableRowProperties? openXmlElement, ConditionalFormatStyle? value)
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

  public static String? GetDivId(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DivId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDivId(PreviousTableRowProperties? openXmlElement, String? value)
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

  public static Int32? GetGridBefore(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GridBefore>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGridBefore(PreviousTableRowProperties? openXmlElement, Int32? value)
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

  public static Int32? GetGridAfter(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GridAfter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGridAfter(PreviousTableRowProperties? openXmlElement, Int32? value)
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

  public static TableWidthType? GetWidthBeforeTableRow(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WidthBeforeTableRow>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWidthBeforeTableRow(PreviousTableRowProperties? openXmlElement, TableWidthType? value)
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

  public static TableWidthType? GetWidthAfterTableRow(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WidthAfterTableRow>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWidthAfterTableRow(PreviousTableRowProperties? openXmlElement, TableWidthType? value)
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

  public static TableRowHeight? GetTableRowHeight(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>();
    if (itemElement != null)
      return TableRowHeightConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableRowHeight(PreviousTableRowProperties? openXmlElement, TableRowHeight? value)
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

  public static Boolean? GetHidden(PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Hidden>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetHidden(PreviousTableRowProperties? openXmlElement, Boolean? value)
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

  public static OnOffOnlyKind? GetCantSplit(PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CantSplit>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCantSplit(PreviousTableRowProperties? openXmlElement, OnOffOnlyKind? value)
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

  public static OnOffOnlyKind? GetTableHeader(PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableHeader>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableHeader(PreviousTableRowProperties? openXmlElement, OnOffOnlyKind? value)
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

  public static TableWidthType? GetTableCellSpacing(PreviousTableRowProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellSpacing>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellSpacing(PreviousTableRowProperties? openXmlElement, TableWidthType? value)
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

  public static TableRowAlignmentKind? GetTableJustification(PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableRowAlignmentValues, TableRowAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableJustification(PreviousTableRowProperties? openXmlElement, TableRowAlignmentKind? value)
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

  public static DocumentModel.Wordprocessing.PreviousTableRowProperties? CreateModelElement(PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousTableRowProperties();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousTableRowProperties? value)
    where OpenXmlElementType : PreviousTableRowProperties, new()
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