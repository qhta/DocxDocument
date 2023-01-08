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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLeftMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public static Int32? GetRightMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightMargin(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Level
  /// </summary>
  public static Int32? GetLevel(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLevel(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Indent
  /// </summary>
  public static Int32? GetIndent(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIndent(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDefaultTabSize(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public static Boolean? GetRightToLeft(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightToLeft(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  public static Boolean? GetEastAsianLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEastAsianLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLatinLineBreak(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  public static Boolean? GetHeight(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  public static DocumentModel.Drawings.LineSpacing? GetLineSpacing(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineSpacing(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.LineSpacing? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  public static DocumentModel.Drawings.SpaceBefore? GetSpaceBefore(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpaceBefore(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.SpaceBefore? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  public static DocumentModel.Drawings.SpaceAfter? GetSpaceAfter(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSpaceAfter(DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType? openXmlElement, DocumentModel.Drawings.SpaceAfter? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
