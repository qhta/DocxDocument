using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using PreviousTablePropertyExceptions = DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions;
using Shading = DocumentModel.Wordprocessing.Shading;
using TableBorders = DocumentModel.Wordprocessing.TableBorders;
using TableCellMarginDefault = DocumentModel.Wordprocessing.TableCellMarginDefault;
using TableIndentation = DocumentModel.Wordprocessing.TableIndentation;
using TableLayout = DocumentModel.Wordprocessing.TableLayout;
using TableLook = DocumentModel.Wordprocessing.TableLook;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Previous Table-Level Property Exceptions.
/// </summary>
public static class PreviousTablePropertyExceptionsConverter
{
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  public static TableWidthType? GetTableWidth(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableWidth>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableWidth(PreviousTablePropertyExceptions? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<TableWidth>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Alignment Exception.
  /// </summary>
  public static TableRowAlignmentKind? GetTableJustification(PreviousTablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableRowAlignmentValues, TableRowAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableJustification(PreviousTablePropertyExceptions? openXmlElement, TableRowAlignmentKind? value)
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

  /// <summary>
  ///   Table Cell Spacing Exception.
  /// </summary>
  public static TableWidthType? GetTableCellSpacing(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellSpacing>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellSpacing(PreviousTablePropertyExceptions? openXmlElement, TableWidthType? value)
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

  /// <summary>
  ///   Table Indent from Leading Margin Exception.
  /// </summary>
  public static TableIndentation? GetTableIndentation(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      return TableIndentationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableIndentation(PreviousTablePropertyExceptions? openXmlElement, TableIndentation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableIndentationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Borders Exceptions.
  /// </summary>
  public static TableBorders? GetTableBorders(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      return TableBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableBorders(PreviousTablePropertyExceptions? openXmlElement, TableBorders? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableBorders>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Shading Exception.
  /// </summary>
  public static Shading? GetShading(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(PreviousTablePropertyExceptions? openXmlElement, Shading? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Layout Exception.
  /// </summary>
  public static TableLayout? GetTableLayout(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
    if (itemElement != null)
      return TableLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableLayout(PreviousTablePropertyExceptions? openXmlElement, TableLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Margin Exceptions.
  /// </summary>
  public static TableCellMarginDefault? GetTableCellMarginDefault(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      return TableCellMarginDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellMarginDefault(PreviousTablePropertyExceptions? openXmlElement, TableCellMarginDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellMarginDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  public static TableLook? GetTableLook(PreviousTablePropertyExceptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
    if (itemElement != null)
      return TableLookConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableLook(PreviousTablePropertyExceptions? openXmlElement, TableLook? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableLookConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableLook>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.PreviousTablePropertyExceptions? CreateModelElement(PreviousTablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousTablePropertyExceptions();
      value.TableWidth = GetTableWidth(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableLayout = GetTableLayout(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      value.TableLook = GetTableLook(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousTablePropertyExceptions? value)
    where OpenXmlElementType : PreviousTablePropertyExceptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableWidth(openXmlElement, value?.TableWidth);
      SetTableJustification(openXmlElement, value?.TableJustification);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableIndentation(openXmlElement, value?.TableIndentation);
      SetTableBorders(openXmlElement, value?.TableBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTableLayout(openXmlElement, value?.TableLayout);
      SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
      SetTableLook(openXmlElement, value?.TableLook);
      return openXmlElement;
    }
    return default;
  }
}