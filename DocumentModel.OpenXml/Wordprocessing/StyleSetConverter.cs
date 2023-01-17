namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public static class StyleSetConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetId(DocumentFormat.OpenXml.Office2010.Word.StyleSet openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2010.Word.StyleSet openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffKind? GetVal(DocumentFormat.OpenXml.Office2010.Word.StyleSet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Office2010.Word.StyleSet openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.StyleSet? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.StyleSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleSet();
      value.Id = GetId(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StyleSet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.StyleSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
