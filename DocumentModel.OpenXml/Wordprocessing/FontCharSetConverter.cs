namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public static class FontCharSetConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.FontCharSet openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.FontCharSet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  private static DocumentModel.Wordprocessing.StrictCharacterSet? GetStrictCharacterSet(DocumentFormat.OpenXml.Wordprocessing.FontCharSet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DocumentModel.Wordprocessing.StrictCharacterSet>(openXmlElement?.StrictCharacterSet?.Value);
  }
  
  private static void SetStrictCharacterSet(DocumentFormat.OpenXml.Wordprocessing.FontCharSet openXmlElement, DocumentModel.Wordprocessing.StrictCharacterSet? value)
  {
    openXmlElement.StrictCharacterSet = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DocumentModel.Wordprocessing.StrictCharacterSet>(value);
  }
  
  public static DocumentModel.Wordprocessing.FontCharSet? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FontCharSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FontCharSet();
      value.Val = GetVal(openXmlElement);
      value.StrictCharacterSet = GetStrictCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FontCharSet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FontCharSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetStrictCharacterSet(openXmlElement, value?.StrictCharacterSet);
      return openXmlElement;
    }
    return default;
  }
}
