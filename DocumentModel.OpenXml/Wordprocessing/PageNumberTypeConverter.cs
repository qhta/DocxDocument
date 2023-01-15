using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using PageNumberType = DocumentFormat.OpenXml.Wordprocessing.PageNumberType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PageNumberType Class.
/// </summary>
public static class PageNumberTypeConverter
{
  /// <summary>
  ///   Page Number Format
  /// </summary>
  public static NumberFormatKind? GetFormat(PageNumberType? openXmlElement)
  {
    return EnumValueConverter.GetValue<NumberFormatValues, NumberFormatKind>(openXmlElement?.Format?.Value);
  }

  public static void SetFormat(PageNumberType? openXmlElement, NumberFormatKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Format = EnumValueConverter.CreateEnumValue<NumberFormatValues, NumberFormatKind>(value);
  }

  /// <summary>
  ///   Starting Page Number
  /// </summary>
  public static Int32? GetStart(PageNumberType? openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }

  public static void SetStart(PageNumberType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Start = value;
  }

  /// <summary>
  ///   Chapter Heading Style
  /// </summary>
  public static Byte? GetChapterStyle(PageNumberType? openXmlElement)
  {
    return openXmlElement?.ChapterStyle?.Value;
  }

  public static void SetChapterStyle(PageNumberType? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChapterStyle = value;
  }

  /// <summary>
  ///   Chapter Separator Character
  /// </summary>
  public static ChapterSeparatorKind? GetChapterSeparator(PageNumberType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ChapterSeparatorValues, ChapterSeparatorKind>(openXmlElement?.ChapterSeparator?.Value);
  }

  public static void SetChapterSeparator(PageNumberType? openXmlElement, ChapterSeparatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChapterSeparator = EnumValueConverter.CreateEnumValue<ChapterSeparatorValues, ChapterSeparatorKind>(value);
  }

  public static DocumentModel.Wordprocessing.PageNumberType? CreateModelElement(PageNumberType? openXmlElement)
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
    where OpenXmlElementType : PageNumberType, new()
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