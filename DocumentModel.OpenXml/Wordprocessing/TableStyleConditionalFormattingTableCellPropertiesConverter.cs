using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Shading = DocumentModel.Wordprocessing.Shading;
using TableCellBorders = DocumentModel.Wordprocessing.TableCellBorders;
using TableCellMargin = DocumentModel.Wordprocessing.TableCellMargin;
using TableStyleConditionalFormattingTableCellProperties = DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableCellPropertiesConverter
{
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public static TableCellBorders? GetTableCellBorders(TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
    if (itemElement != null)
      return TableCellBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellBorders(TableStyleConditionalFormattingTableCellProperties? openXmlElement, TableCellBorders? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shading.
  /// </summary>
  public static Shading? GetShading(TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(TableStyleConditionalFormattingTableCellProperties? openXmlElement, Shading? value)
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
  ///   NoWrap.
  /// </summary>
  public static OnOffOnlyKind? GetNoWrap(TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoWrap>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNoWrap(TableStyleConditionalFormattingTableCellProperties? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NoWrap, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public static TableCellMargin? GetTableCellMargin(TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      return TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellMargin(TableStyleConditionalFormattingTableCellProperties? openXmlElement, TableCellMargin? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellMarginConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public static TableVerticalAlignmentKind? GetTableCellVerticalAlignment(TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCellVerticalAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableVerticalAlignmentValues, TableVerticalAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableCellVerticalAlignment(TableStyleConditionalFormattingTableCellProperties? openXmlElement, TableVerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCellVerticalAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TableCellVerticalAlignment, TableVerticalAlignmentValues, TableVerticalAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? CreateModelElement(TableStyleConditionalFormattingTableCellProperties? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? value)
    where OpenXmlElementType : TableStyleConditionalFormattingTableCellProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableCellBorders(openXmlElement, value?.TableCellBorders);
      SetShading(openXmlElement, value?.Shading);
      SetNoWrap(openXmlElement, value?.NoWrap);
      SetTableCellMargin(openXmlElement, value?.TableCellMargin);
      SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
      return openXmlElement;
    }
    return default;
  }
}