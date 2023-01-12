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
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
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
    return openXmlElement?.ChapterNumber?.Value;
  }
  
  public static void SetChapterNumber(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ChapterNumber = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.ChapterNumber = null;
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public static Int32? GetHeading(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    return openXmlElement?.Heading?.Value;
  }
  
  public static void SetHeading(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Heading = value;
  }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public static Boolean? GetNoLabel(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    return openXmlElement?.NoLabel?.Value;
  }
  
  public static void SetNoLabel(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoLabel = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.NoLabel = null;
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
  
  public static DocumentModel.Wordprocessing.Caption? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Caption? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Caption();
      value.Name = GetName(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.ChapterNumber = GetChapterNumber(openXmlElement);
      value.Heading = GetHeading(openXmlElement);
      value.NoLabel = GetNoLabel(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Caption? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Caption, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetPosition(openXmlElement, value?.Position);
      SetChapterNumber(openXmlElement, value?.ChapterNumber);
      SetHeading(openXmlElement, value?.Heading);
      SetNoLabel(openXmlElement, value?.NoLabel);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetSeparator(openXmlElement, value?.Separator);
      return openXmlElement;
    }
    return default;
  }
}
