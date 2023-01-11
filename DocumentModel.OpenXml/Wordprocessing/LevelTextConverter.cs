namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public static class LevelTextConverter
{
  /// <summary>
  /// Level Text
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.LevelText? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.LevelText? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public static Boolean? GetNull(DocumentFormat.OpenXml.Wordprocessing.LevelText? openXmlElement)
  {
    return openXmlElement?.Null?.Value;
  }
  
  public static void SetNull(DocumentFormat.OpenXml.Wordprocessing.LevelText? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Null = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Null = null;
  }
  
  public static DocumentModel.Wordprocessing.LevelText? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.LevelText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LevelText();
      value.Val = GetVal(openXmlElement);
      value.Null = GetNull(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LevelText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LevelText, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
