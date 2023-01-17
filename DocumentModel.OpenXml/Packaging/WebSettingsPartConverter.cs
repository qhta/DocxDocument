namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public static class WebSettingsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.WebSettingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WebSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Wordprocessing.WebSettings? GetWebSettings(DocumentFormat.OpenXml.Packaging.WebSettingsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.WebSettings rootElement)
      return DocumentModel.OpenXml.Wordprocessing.WebSettingsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetWebSettings(DocumentFormat.OpenXml.Packaging.WebSettingsPart openXmlElement, DocumentModel.Wordprocessing.WebSettings? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Wordprocessing.WebSettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.WebSettings>(value);
       if (rootElement != null)
         openXmlElement.WebSettings = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.WebSettingsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WebSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WebSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebSettings = GetWebSettings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WebSettingsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WebSettingsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetWebSettings(openXmlElement, value?.WebSettings);
      return openXmlElement;
    }
    return default;
  }
}
