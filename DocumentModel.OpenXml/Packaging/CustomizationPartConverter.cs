namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public static class CustomizationPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.TemplateCommandGroup? GetTemplateCommandGroup(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup rootElement)
      return DocumentModel.OpenXml.Wordprocessing.TemplateCommandGroupConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetTemplateCommandGroup(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement, DocumentModel.Wordprocessing.TemplateCommandGroup? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.TemplateCommandGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup>(value);
         if (rootElement != null)
           openXmlElement.TemplateCommandGroup = rootElement;
      }
  }
  
  public static DocumentModel.Packaging.CustomizationPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomizationPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.TemplateCommandGroup = GetTemplateCommandGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomizationPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CustomizationPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTemplateCommandGroup(openXmlElement, value?.TemplateCommandGroup);
      return openXmlElement;
    }
    return default;
  }
}
