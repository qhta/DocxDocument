using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using RunPropertiesBaseStyle = DocumentModel.Wordprocessing.RunPropertiesBaseStyle;
using StyleParagraphProperties = DocumentModel.Wordprocessing.StyleParagraphProperties;
using TableStyleConditionalFormattingTableCellProperties = DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties;
using TableStyleConditionalFormattingTableProperties = DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties;
using TableStyleConditionalFormattingTableRowProperties = DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties;
using TableStyleProperties = DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Style Conditional Table Formatting Properties.
/// </summary>
public static class TableStylePropertiesConverter
{
  /// <summary>
  ///   Table Style Conditional Formatting Type
  /// </summary>
  public static TableStyleOverrideKind? GetType(TableStyleProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TableStyleOverrideValues, TableStyleOverrideKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(TableStyleProperties? openXmlElement, TableStyleOverrideKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<TableStyleOverrideValues, TableStyleOverrideKind>(value);
  }

  /// <summary>
  ///   Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public static StyleParagraphProperties? GetStyleParagraphProperties(TableStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
    if (itemElement != null)
      return StyleParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleParagraphProperties(TableStyleProperties? openXmlElement, StyleParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Style Conditional Formatting Run Properties.
  /// </summary>
  public static RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(TableStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
    if (itemElement != null)
      return RunPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunPropertiesBaseStyle(TableStyleProperties? openXmlElement, RunPropertiesBaseStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Style Conditional Formatting Table Properties.
  /// </summary>
  public static TableStyleConditionalFormattingTableProperties? GetTableStyleConditionalFormattingTableProperties(TableStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>();
    if (itemElement != null)
      return TableStyleConditionalFormattingTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableStyleConditionalFormattingTableProperties(TableStyleProperties? openXmlElement, TableStyleConditionalFormattingTableProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public static TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(TableStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      return TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableStyleConditionalFormattingTableRowProperties(TableStyleProperties? openXmlElement, TableStyleConditionalFormattingTableRowProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public static TableStyleConditionalFormattingTableCellProperties? GetTableStyleConditionalFormattingTableCellProperties(TableStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>();
    if (itemElement != null)
      return TableStyleConditionalFormattingTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableStyleConditionalFormattingTableCellProperties(TableStyleProperties? openXmlElement, TableStyleConditionalFormattingTableCellProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableStyleConditionalFormattingTableCellPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableStyleProperties? CreateModelElement(TableStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableStyleProperties();
      value.Type = GetType(openXmlElement);
      value.StyleParagraphProperties = GetStyleParagraphProperties(openXmlElement);
      value.RunPropertiesBaseStyle = GetRunPropertiesBaseStyle(openXmlElement);
      value.TableStyleConditionalFormattingTableProperties = GetTableStyleConditionalFormattingTableProperties(openXmlElement);
      value.TableStyleConditionalFormattingTableRowProperties = GetTableStyleConditionalFormattingTableRowProperties(openXmlElement);
      value.TableStyleConditionalFormattingTableCellProperties = GetTableStyleConditionalFormattingTableCellProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableStyleProperties? value)
    where OpenXmlElementType : TableStyleProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStyleParagraphProperties(openXmlElement, value?.StyleParagraphProperties);
      SetRunPropertiesBaseStyle(openXmlElement, value?.RunPropertiesBaseStyle);
      SetTableStyleConditionalFormattingTableProperties(openXmlElement, value?.TableStyleConditionalFormattingTableProperties);
      SetTableStyleConditionalFormattingTableRowProperties(openXmlElement, value?.TableStyleConditionalFormattingTableRowProperties);
      SetTableStyleConditionalFormattingTableCellProperties(openXmlElement, value?.TableStyleConditionalFormattingTableCellProperties);
      return openXmlElement;
    }
    return default;
  }
}