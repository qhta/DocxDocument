namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public static class NumberingFormatConverter
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberFormatKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DocumentModel.Wordprocessing.NumberFormatKind>(openXmlElement?.Val?.Value);
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? openXmlElement, DocumentModel.Wordprocessing.NumberFormatKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DocumentModel.Wordprocessing.NumberFormatKind>(value);
  }
  
  /// <summary>
  /// format, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetFormat(DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? openXmlElement)
  {
    return openXmlElement?.Format?.Value;
  }
  
  public static void SetFormat(DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Format = new StringValue { Value = value };
      else
        openXmlElement.Format = null;
  }
  
  public static DocumentModel.Wordprocessing.NumberingFormat? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingFormat();
      value.Val = GetVal(openXmlElement);
      value.Format = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingFormat? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NumberingFormat, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
