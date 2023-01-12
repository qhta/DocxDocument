namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class TitleConverter
{
  /// <summary>
  /// Language
  /// </summary>
  public static String? GetLanguage(DocumentFormat.OpenXml.Drawing.Diagrams.Title? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  public static void SetLanguage(DocumentFormat.OpenXml.Drawing.Diagrams.Title? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Title? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Title? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.Title? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Title? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Title();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Title? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Title, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLanguage(openXmlElement, value?.Language);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
