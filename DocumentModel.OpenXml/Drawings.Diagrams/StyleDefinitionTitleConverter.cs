namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class StyleDefinitionTitleConverter
{
  /// <summary>
  /// Natural Language
  /// </summary>
  public static String? GetLanguage(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  public static void SetLanguage(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDefinitionTitle? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDefinitionTitle();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDefinitionTitle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
