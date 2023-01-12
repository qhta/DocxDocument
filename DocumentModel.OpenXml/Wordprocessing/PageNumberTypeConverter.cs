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
    return openXmlElement?.Start?.Value;
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Start = value;
  }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  public static Byte? GetChapterStyle(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement)
  {
    return openXmlElement?.ChapterStyle?.Value;
  }
  
  public static void SetChapterStyle(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChapterStyle = value;
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
  
  public static DocumentModel.Wordprocessing.PageNumberType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PageNumberType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageNumberType();
      value.Format = GetFormat(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.ChapterStyle = GetChapterStyle(openXmlElement);
      value.ChapterSeparator = GetChapterSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageNumberType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PageNumberType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormat(openXmlElement, value?.Format);
      SetStart(openXmlElement, value?.Start);
      SetChapterStyle(openXmlElement, value?.ChapterStyle);
      SetChapterSeparator(openXmlElement, value?.ChapterSeparator);
      return openXmlElement;
    }
    return default;
  }
}
