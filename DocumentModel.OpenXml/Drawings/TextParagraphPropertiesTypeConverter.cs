using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using LineSpacing = DocumentModel.Drawings.LineSpacing;
using SpaceAfter = DocumentModel.Drawings.SpaceAfter;
using SpaceBefore = DocumentModel.Drawings.SpaceBefore;
using TextParagraphPropertiesType = DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the TextParagraphPropertiesType Class.
/// </summary>
public static class TextParagraphPropertiesTypeConverter
{
  /// <summary>
  ///   Left Margin
  /// </summary>
  public static Int32? GetLeftMargin(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.LeftMargin?.Value;
  }

  public static void SetLeftMargin(TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftMargin = value;
  }

  /// <summary>
  ///   Right Margin
  /// </summary>
  public static Int32? GetRightMargin(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.RightMargin?.Value;
  }

  public static void SetRightMargin(TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightMargin = value;
  }

  /// <summary>
  ///   Level
  /// </summary>
  public static Int32? GetLevel(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.Level?.Value;
  }

  public static void SetLevel(TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Level = value;
  }

  /// <summary>
  ///   Indent
  /// </summary>
  public static Int32? GetIndent(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.Indent?.Value;
  }

  public static void SetIndent(TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Indent = value;
  }

  /// <summary>
  ///   Alignment
  /// </summary>
  public static TextAlignmentKind? GetAlignment(TextParagraphPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextAlignmentTypeValues, TextAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(TextParagraphPropertiesType? openXmlElement, TextAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<TextAlignmentTypeValues, TextAlignmentKind>(value);
  }

  /// <summary>
  ///   Default Tab Size
  /// </summary>
  public static Int32? GetDefaultTabSize(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.DefaultTabSize?.Value;
  }

  public static void SetDefaultTabSize(TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DefaultTabSize = value;
  }

  /// <summary>
  ///   Right To Left
  /// </summary>
  public static Boolean? GetRightToLeft(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.RightToLeft?.Value;
  }

  public static void SetRightToLeft(TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RightToLeft = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RightToLeft = null;
  }

  /// <summary>
  ///   East Asian Line Break
  /// </summary>
  public static Boolean? GetEastAsianLineBreak(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.EastAsianLineBreak?.Value;
  }

  public static void SetEastAsianLineBreak(TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EastAsianLineBreak = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.EastAsianLineBreak = null;
  }

  /// <summary>
  ///   Font Alignment
  /// </summary>
  public static TextFontAlignmentKind? GetFontAlignment(TextParagraphPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextFontAlignmentValues, TextFontAlignmentKind>(openXmlElement?.FontAlignment?.Value);
  }

  public static void SetFontAlignment(TextParagraphPropertiesType? openXmlElement, TextFontAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontAlignment = EnumValueConverter.CreateEnumValue<TextFontAlignmentValues, TextFontAlignmentKind>(value);
  }

  /// <summary>
  ///   Latin Line Break
  /// </summary>
  public static Boolean? GetLatinLineBreak(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.LatinLineBreak?.Value;
  }

  public static void SetLatinLineBreak(TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LatinLineBreak = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LatinLineBreak = null;
  }

  /// <summary>
  ///   Hanging Punctuation
  /// </summary>
  public static Boolean? GetHeight(TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Height = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Height = null;
  }

  /// <summary>
  ///   Line Spacing.
  /// </summary>
  public static LineSpacing? GetLineSpacing(TextParagraphPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
    if (itemElement != null)
      return LineSpacingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineSpacing(TextParagraphPropertiesType? openXmlElement, LineSpacing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSpacingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineSpacing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Space Before.
  /// </summary>
  public static SpaceBefore? GetSpaceBefore(TextParagraphPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
    if (itemElement != null)
      return SpaceBeforeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpaceBefore(TextParagraphPropertiesType? openXmlElement, SpaceBefore? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceBeforeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceBefore>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Space After.
  /// </summary>
  public static SpaceAfter? GetSpaceAfter(TextParagraphPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
    if (itemElement != null)
      return SpaceAfterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSpaceAfter(TextParagraphPropertiesType? openXmlElement, SpaceAfter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpaceAfterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceAfter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.TextParagraphPropertiesType? CreateModelElement(TextParagraphPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextParagraphPropertiesType();
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.Level = GetLevel(openXmlElement);
      value.Indent = GetIndent(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.DefaultTabSize = GetDefaultTabSize(openXmlElement);
      value.RightToLeft = GetRightToLeft(openXmlElement);
      value.EastAsianLineBreak = GetEastAsianLineBreak(openXmlElement);
      value.FontAlignment = GetFontAlignment(openXmlElement);
      value.LatinLineBreak = GetLatinLineBreak(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.LineSpacing = GetLineSpacing(openXmlElement);
      value.SpaceBefore = GetSpaceBefore(openXmlElement);
      value.SpaceAfter = GetSpaceAfter(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TextParagraphPropertiesType? value)
    where OpenXmlElementType : TextParagraphPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftMargin(openXmlElement, value?.LeftMargin);
      SetRightMargin(openXmlElement, value?.RightMargin);
      SetLevel(openXmlElement, value?.Level);
      SetIndent(openXmlElement, value?.Indent);
      SetAlignment(openXmlElement, value?.Alignment);
      SetDefaultTabSize(openXmlElement, value?.DefaultTabSize);
      SetRightToLeft(openXmlElement, value?.RightToLeft);
      SetEastAsianLineBreak(openXmlElement, value?.EastAsianLineBreak);
      SetFontAlignment(openXmlElement, value?.FontAlignment);
      SetLatinLineBreak(openXmlElement, value?.LatinLineBreak);
      SetHeight(openXmlElement, value?.Height);
      SetLineSpacing(openXmlElement, value?.LineSpacing);
      SetSpaceBefore(openXmlElement, value?.SpaceBefore);
      SetSpaceAfter(openXmlElement, value?.SpaceAfter);
      return openXmlElement;
    }
    return default;
  }
}