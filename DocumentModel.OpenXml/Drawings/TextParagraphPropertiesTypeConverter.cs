namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public static class TextParagraphPropertiesTypeConverter
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public static Int32? GetLeftMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.LeftMargin?.Value;
  }
  
  public static void SetLeftMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftMargin = value;
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public static Int32? GetRightMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.RightMargin?.Value;
  }
  
  public static void SetRightMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightMargin = value;
  }
  
  /// <summary>
  /// Level
  /// </summary>
  public static Int32? GetLevel(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.Level?.Value;
  }
  
  public static void SetLevel(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Level = value;
  }
  
  /// <summary>
  /// Indent
  /// </summary>
  public static Int32? GetIndent(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.Indent?.Value;
  }
  
  public static void SetIndent(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Indent = value;
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public static DocumentModel.Drawings.TextAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DocumentModel.Drawings.TextAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.TextAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DocumentModel.Drawings.TextAlignmentKind>(value);
  }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  public static Int32? GetDefaultTabSize(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.DefaultTabSize?.Value;
  }
  
  public static void SetDefaultTabSize(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DefaultTabSize = value;
  }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public static Boolean? GetRightToLeft(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.RightToLeft?.Value;
  }
  
  public static void SetRightToLeft(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RightToLeft = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RightToLeft = null;
  }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public static Boolean? GetEastAsianLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.EastAsianLineBreak?.Value;
  }
  
  public static void SetEastAsianLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EastAsianLineBreak = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.EastAsianLineBreak = null;
  }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  public static DocumentModel.Drawings.TextFontAlignmentKind? GetFontAlignment(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DocumentModel.Drawings.TextFontAlignmentKind>(openXmlElement?.FontAlignment?.Value);
  }
  
  public static void SetFontAlignment(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.TextFontAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DocumentModel.Drawings.TextFontAlignmentKind>(value);
  }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  public static Boolean? GetLatinLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.LatinLineBreak?.Value;
  }
  
  public static void SetLatinLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LatinLineBreak = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LatinLineBreak = null;
  }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public static Boolean? GetHeight(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Height = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Height = null;
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public static DocumentModel.Drawings.LineSpacing? GetLineSpacing(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineSpacingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineSpacing(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.LineSpacing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LineSpacingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineSpacing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public static DocumentModel.Drawings.SpaceBefore? GetSpaceBefore(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SpaceBeforeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSpaceBefore(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.SpaceBefore? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SpaceBeforeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceBefore>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public static DocumentModel.Drawings.SpaceAfter? GetSpaceAfter(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SpaceAfterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSpaceAfter(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.SpaceAfter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SpaceAfterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SpaceAfter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextParagraphPropertiesType? CreateModelElement(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType, new()
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
