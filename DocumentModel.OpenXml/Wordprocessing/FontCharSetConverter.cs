namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public static class FontCharSetConverter
{
  /// <summary>
  /// val
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.FontCharSet? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.FontCharSet? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public static DocumentModel.Wordprocessing.StrictCharacterSet? GetStrictCharacterSet(DocumentFormat.OpenXml.Wordprocessing.FontCharSet? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DocumentModel.Wordprocessing.StrictCharacterSet>(openXmlElement?.StrictCharacterSet?.Value);
  }
  
  public static void SetStrictCharacterSet(DocumentFormat.OpenXml.Wordprocessing.FontCharSet? openXmlElement, DocumentModel.Wordprocessing.StrictCharacterSet? value)
  {
    if (openXmlElement != null)
      openXmlElement.StrictCharacterSet = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DocumentModel.Wordprocessing.StrictCharacterSet>(value);
  }
  
}
