namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Set of Characters Which Cannot End a Line.
/// </summary>
public static class NoLineBreaksAfterKinsokuConverter
{
  /// <summary>
  /// lang
  /// </summary>
  public static String? GetLanguage(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  public static void SetLanguage(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
