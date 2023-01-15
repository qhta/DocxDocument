using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Shading = DocumentModel.Wordprocessing.Shading;
using TableBorders = DocumentModel.Wordprocessing.TableBorders;
using TableCellMarginDefault = DocumentModel.Wordprocessing.TableCellMarginDefault;
using TableIndentation = DocumentModel.Wordprocessing.TableIndentation;
using TableLayout = DocumentModel.Wordprocessing.TableLayout;
using TableLook = DocumentModel.Wordprocessing.TableLook;
using TablePositionProperties = DocumentModel.Wordprocessing.TablePositionProperties;
using TableProperties = DocumentFormat.OpenXml.Wordprocessing.TableProperties;
using TablePropertiesChange = DocumentModel.Wordprocessing.TablePropertiesChange;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Table Properties.
/// </summary>
public static class TablePropertiesConverter
{
  /// <summary>
  ///   TableStyle.
  /// </summary>
  public static String? GetTableStyle(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTableStyle(TableProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TableStyle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TablePositionProperties.
  /// </summary>
  public static TablePositionProperties? GetTablePositionProperties(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>();
    if (itemElement != null)
      return TablePositionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTablePositionProperties(TableProperties? openXmlElement, TablePositionProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TablePositionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableOverlap.
  /// </summary>
  public static TableOverlapKind? GetTableOverlap(TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableOverlap>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableOverlapValues, TableOverlapKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableOverlap(TableProperties? openXmlElement, TableOverlapKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableOverlap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TableOverlap, TableOverlapValues, TableOverlapKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BiDiVisual.
  /// </summary>
  public static OnOffOnlyKind? GetBiDiVisual(TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDiVisual>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBiDiVisual(TableProperties? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BiDiVisual>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BiDiVisual, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableWidth.
  /// </summary>
  public static TableWidthType? GetTableWidth(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableWidth>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableWidth(TableProperties? openXmlElement, TableWidthType? value)
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
  ///   TableJustification.
  /// </summary>
  public static TableRowAlignmentKind? GetTableJustification(TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableRowAlignmentValues, TableRowAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableJustification(TableProperties? openXmlElement, TableRowAlignmentKind? value)
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
  public static TableWidthType? GetTableCellSpacing(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellSpacing>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellSpacing(TableProperties? openXmlElement, TableWidthType? value)
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
  public static TableIndentation? GetTableIndentation(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      return TableIndentationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableIndentation(TableProperties? openXmlElement, TableIndentation? value)
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
  public static TableBorders? GetTableBorders(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      return TableBordersConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableBorders(TableProperties? openXmlElement, TableBorders? value)
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
  public static Shading? GetShading(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(TableProperties? openXmlElement, Shading? value)
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
  ///   TableLayout.
  /// </summary>
  public static TableLayout? GetTableLayout(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLayout>();
    if (itemElement != null)
      return TableLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableLayout(TableProperties? openXmlElement, TableLayout? value)
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
  ///   TableCellMarginDefault.
  /// </summary>
  public static TableCellMarginDefault? GetTableCellMarginDefault(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      return TableCellMarginDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellMarginDefault(TableProperties? openXmlElement, TableCellMarginDefault? value)
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
  ///   TableLook.
  /// </summary>
  public static TableLook? GetTableLook(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableLook>();
    if (itemElement != null)
      return TableLookConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableLook(TableProperties? openXmlElement, TableLook? value)
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

  /// <summary>
  ///   TableCaption, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetTableCaption(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCaption>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTableCaption(TableProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCaption>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TableCaption { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TableDescription, this property is only available in Office 2010 and later..
  /// </summary>
  public static String? GetTableDescription(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableDescription>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTableDescription(TableProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableDescription>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TableDescription { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Revision Information for Table Properties.
  /// </summary>
  public static TablePropertiesChange? GetTablePropertiesChange(TableProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange>();
    if (itemElement != null)
      return TablePropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTablePropertiesChange(TableProperties? openXmlElement, TablePropertiesChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TablePropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableProperties? CreateModelElement(TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableProperties();
      value.TableStyle = GetTableStyle(openXmlElement);
      value.TablePositionProperties = GetTablePositionProperties(openXmlElement);
      value.TableOverlap = GetTableOverlap(openXmlElement);
      value.BiDiVisual = GetBiDiVisual(openXmlElement);
      value.TableWidth = GetTableWidth(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableLayout = GetTableLayout(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      value.TableLook = GetTableLook(openXmlElement);
      value.TableCaption = GetTableCaption(openXmlElement);
      value.TableDescription = GetTableDescription(openXmlElement);
      value.TablePropertiesChange = GetTablePropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableProperties? value)
    where OpenXmlElementType : TableProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableStyle(openXmlElement, value?.TableStyle);
      SetTablePositionProperties(openXmlElement, value?.TablePositionProperties);
      SetTableOverlap(openXmlElement, value?.TableOverlap);
      SetBiDiVisual(openXmlElement, value?.BiDiVisual);
      SetTableWidth(openXmlElement, value?.TableWidth);
      SetTableJustification(openXmlElement, value?.TableJustification);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableIndentation(openXmlElement, value?.TableIndentation);
      SetTableBorders(openXmlElement, value?.TableBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTableLayout(openXmlElement, value?.TableLayout);
      SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
      SetTableLook(openXmlElement, value?.TableLook);
      SetTableCaption(openXmlElement, value?.TableCaption);
      SetTableDescription(openXmlElement, value?.TableDescription);
      SetTablePropertiesChange(openXmlElement, value?.TablePropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}