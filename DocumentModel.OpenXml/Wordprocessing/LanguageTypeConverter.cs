namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LanguageType Class.
/// </summary>
public static class LanguageTypeConverter
{
  /// <summary>
  /// Latin Language
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  public static String? GetEastAsia(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }
  
  public static void SetEastAsia(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EastAsia = new StringValue { Value = value };
      else
        openXmlElement.EastAsia = null;
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  public static String? GetBidi(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement)
  {
    return openXmlElement?.Bidi?.Value;
  }
  
  public static void SetBidi(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bidi = new StringValue { Value = value };
      else
        openXmlElement.Bidi = null;
  }
  
  public static DocumentModel.Wordprocessing.LanguageType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.LanguageType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LanguageType();
      value.Val = GetVal(openXmlElement);
      value.EastAsia = GetEastAsia(openXmlElement);
      value.Bidi = GetBidi(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LanguageType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LanguageType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
