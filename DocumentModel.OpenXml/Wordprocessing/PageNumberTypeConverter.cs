namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public static class PageNumberTypeConverter
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberFormatKind? GetFormat(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DocumentModel.Wordprocessing.NumberFormatKind>(openXmlElement?.Format?.Value);
  }
  
  public static void SetFormat(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement, DocumentModel.Wordprocessing.NumberFormatKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Format = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DocumentModel.Wordprocessing.NumberFormatKind>(value);
  }
  
  /// <summary>
  /// Starting Page Number
  /// </summary>
  public static Int32? GetStart(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  public static Byte? GetChapterStyle(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChapterStyle(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public static DocumentModel.Wordprocessing.ChapterSeparatorKind? GetChapterSeparator(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DocumentModel.Wordprocessing.ChapterSeparatorKind>(openXmlElement?.ChapterSeparator?.Value);
  }
  
  public static void SetChapterSeparator(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement, DocumentModel.Wordprocessing.ChapterSeparatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChapterSeparator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DocumentModel.Wordprocessing.ChapterSeparatorKind>(value);
  }
  
}
