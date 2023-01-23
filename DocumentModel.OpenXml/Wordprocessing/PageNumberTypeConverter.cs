namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public static class PageNumberTypeConverter
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  private static DMW.NumberFormatKind? GetFormat(DXW.PageNumberType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Format?.Value);
  }
  
  private static bool CmpFormat(DXW.PageNumberType openXmlElement, DMW.NumberFormatKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Format?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormat(DXW.PageNumberType openXmlElement, DMW.NumberFormatKind? value)
  {
    openXmlElement.Format = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(value);
  }
  
  /// <summary>
  /// Starting Page Number
  /// </summary>
  private static Int32? GetStart(DXW.PageNumberType openXmlElement)
  {
    return openXmlElement.Start?.Value;
  }
  
  private static bool CmpStart(DXW.PageNumberType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Start?.Value == value;
  }
  
  private static void SetStart(DXW.PageNumberType openXmlElement, Int32? value)
  {
    openXmlElement.Start = value;
  }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  private static Byte? GetChapterStyle(DXW.PageNumberType openXmlElement)
  {
    return openXmlElement.ChapterStyle?.Value;
  }
  
  private static bool CmpChapterStyle(DXW.PageNumberType openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ChapterStyle?.Value == value;
  }
  
  private static void SetChapterStyle(DXW.PageNumberType openXmlElement, Byte? value)
  {
    openXmlElement.ChapterStyle = value;
  }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  private static DMW.ChapterSeparatorKind? GetChapterSeparator(DXW.PageNumberType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(openXmlElement?.ChapterSeparator?.Value);
  }
  
  private static bool CmpChapterSeparator(DXW.PageNumberType openXmlElement, DMW.ChapterSeparatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(openXmlElement?.ChapterSeparator?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChapterSeparator(DXW.PageNumberType openXmlElement, DMW.ChapterSeparatorKind? value)
  {
    openXmlElement.ChapterSeparator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DMW.ChapterSeparatorKind>(value);
  }
  
  public static DMW.PageNumberType? CreateModelElement(DXW.PageNumberType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PageNumberType();
      value.Format = GetFormat(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.ChapterStyle = GetChapterStyle(openXmlElement);
      value.ChapterSeparator = GetChapterSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PageNumberType? openXmlElement, DMW.PageNumberType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormat(openXmlElement, value.Format, diffs, objName))
        ok = false;
      if (!CmpStart(openXmlElement, value.Start, diffs, objName))
        ok = false;
      if (!CmpChapterStyle(openXmlElement, value.ChapterStyle, diffs, objName))
        ok = false;
      if (!CmpChapterSeparator(openXmlElement, value.ChapterSeparator, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PageNumberType? value)
    where OpenXmlElementType: DXW.PageNumberType, new()
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
