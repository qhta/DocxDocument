namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class ColorDefinitionTitleConverter
{
  /// <summary>
  /// Language
  /// </summary>
  private static String? GetLanguage(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorDefinitionTitle? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorDefinitionTitle();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorDefinitionTitle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle, new()
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
