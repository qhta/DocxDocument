using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Shading = DocumentModel.Wordprocessing.Shading;
using StyleTableProperties = DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties;
using TableBorders = DocumentModel.Wordprocessing.TableBorders;
using TableCellMarginDefault = DocumentModel.Wordprocessing.TableCellMarginDefault;
using TableIndentation = DocumentModel.Wordprocessing.TableIndentation;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Style Table Properties.
/// </summary>
public static class StyleTablePropertiesConverter
{
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  public static Int32? GetTableStyleRowBandSize(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableStyleRowBandSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTableStyleRowBandSize(StyleTableProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableStyleRowBandSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TableStyleRowBandSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  public static Int32? GetTableStyleColumnBandSize(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableStyleColumnBandSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTableStyleColumnBandSize(StyleTableProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableStyleColumnBandSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TableStyleColumnBandSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableJustification.
  /// </summary>
  public static TableRowAlignmentKind? GetTableJustification(StyleTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableRowAlignmentValues, TableRowAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableJustification(StyleTableProperties? openXmlElement, TableRowAlignmentKind? value)
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
  ///   TableCellSpacing.
  /// </summary>
  public static TableWidthType? GetTableCellSpacing(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellSpacing>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellSpacing(StyleTableProperties? openXmlElement, TableWidthType? value)
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
  ///   TableIndentation.
  /// </summary>
  public static TableIndentation? GetTableIndentation(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      return TableIndentationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableIndentation(StyleTableProperties? openXmlElement, TableIndentation? value)
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
  ///   TableBorders.
  /// </summary>
  public static TableBorders? GetTableBorders(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      return TableBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableBorders(StyleTableProperties? openXmlElement, TableBorders? value)
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
  ///   Shading.
  /// </summary>
  public static Shading? GetShading(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(StyleTableProperties? openXmlElement, Shading? value)
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
  ///   TableCellMarginDefault.
  /// </summary>
  public static TableCellMarginDefault? GetTableCellMarginDefault(StyleTableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      return TableCellMarginDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellMarginDefault(StyleTableProperties? openXmlElement, TableCellMarginDefault? value)
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

  public static DocumentModel.Wordprocessing.StyleTableProperties? CreateModelElement(StyleTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleTableProperties();
      value.TableStyleRowBandSize = GetTableStyleRowBandSize(openXmlElement);
      value.TableStyleColumnBandSize = GetTableStyleColumnBandSize(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StyleTableProperties? value)
    where OpenXmlElementType : StyleTableProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableStyleRowBandSize(openXmlElement, value?.TableStyleRowBandSize);
      SetTableStyleColumnBandSize(openXmlElement, value?.TableStyleColumnBandSize);
      SetTableJustification(openXmlElement, value?.TableJustification);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableIndentation(openXmlElement, value?.TableIndentation);
      SetTableBorders(openXmlElement, value?.TableBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
      return openXmlElement;
    }
    return default;
  }
}