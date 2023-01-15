using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Shading = DocumentModel.Wordprocessing.Shading;
using StyleTableCellProperties = DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties;
using TableCellMargin = DocumentModel.Wordprocessing.TableCellMargin;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Style Table Cell Properties.
/// </summary>
public static class StyleTableCellPropertiesConverter
{
  /// <summary>
  ///   Shading.
  /// </summary>
  public static Shading? GetShading(StyleTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return ShadingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShading(StyleTableCellProperties? openXmlElement, Shading? value)
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
  public static OnOffOnlyKind? GetNoWrap(StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoWrap>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNoWrap(StyleTableCellProperties? openXmlElement, OnOffOnlyKind? value)
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
  public static TableCellMargin? GetTableCellMargin(StyleTableCellProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      return TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellMargin(StyleTableCellProperties? openXmlElement, TableCellMargin? value)
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
  public static TableVerticalAlignmentKind? GetTableCellVerticalAlignment(StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCellVerticalAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TableVerticalAlignmentValues, TableVerticalAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTableCellVerticalAlignment(StyleTableCellProperties? openXmlElement, TableVerticalAlignmentKind? value)
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

  public static DocumentModel.Wordprocessing.StyleTableCellProperties? CreateModelElement(StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleTableCellProperties();
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StyleTableCellProperties? value)
    where OpenXmlElementType : StyleTableCellProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShading(openXmlElement, value?.Shading);
      SetNoWrap(openXmlElement, value?.NoWrap);
      SetTableCellMargin(openXmlElement, value?.TableCellMargin);
      SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
      return openXmlElement;
    }
    return default;
  }
}