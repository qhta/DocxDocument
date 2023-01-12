namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public static class WebSettingsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WebSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WebSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.WebSettings? GetWebSettings(DocumentFormat.OpenXml.Packaging.WebSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetWebSettings(DocumentFormat.OpenXml.Packaging.WebSettingsPart? openXmlElement, DocumentModel.Wordprocessing.WebSettings? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
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
      SetWebSettings(openXmlElement, value?.WebSettings);
      return openXmlElement;
    }
    return default;
  }
}
