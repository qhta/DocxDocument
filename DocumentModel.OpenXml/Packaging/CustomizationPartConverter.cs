namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public static class CustomizationPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.TemplateCommandGroup? GetTemplateCommandGroup(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetTemplateCommandGroup(DocumentFormat.OpenXml.Packaging.CustomizationPart? openXmlElement, DocumentModel.Wordprocessing.TemplateCommandGroup? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
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
      SetTemplateCommandGroup(openXmlElement, value?.TemplateCommandGroup);
      return openXmlElement;
    }
    return default;
  }
}
