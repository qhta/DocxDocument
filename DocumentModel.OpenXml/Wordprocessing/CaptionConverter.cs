namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public static class CaptionConverter
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public static DocumentModel.Wordprocessing.CaptionPositionKind? GetPosition(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues, DocumentModel.Wordprocessing.CaptionPositionKind>(openXmlElement?.Position?.Value);
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, DocumentModel.Wordprocessing.CaptionPositionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Position = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues, DocumentModel.Wordprocessing.CaptionPositionKind>(value);
  }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  public static Boolean? GetChapterNumber(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChapterNumber(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public static Int32? GetHeading(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeading(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public static Boolean? GetNoLabel(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoLabel(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberFormatKind? GetNumberFormat(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DocumentModel.Wordprocessing.NumberFormatKind>(openXmlElement?.NumberFormat?.Value);
  }
  
  public static void SetNumberFormat(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, DocumentModel.Wordprocessing.NumberFormatKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberFormat = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DocumentModel.Wordprocessing.NumberFormatKind>(value);
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public static DocumentModel.Wordprocessing.ChapterSeparatorKind? GetSeparator(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DocumentModel.Wordprocessing.ChapterSeparatorKind>(openXmlElement?.Separator?.Value);
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, DocumentModel.Wordprocessing.ChapterSeparatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Separator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues, DocumentModel.Wordprocessing.ChapterSeparatorKind>(value);
  }
  
}
