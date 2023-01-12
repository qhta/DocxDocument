namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public static class DocumentTasksPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DocumentTasksPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DocumentTasksPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Tasks? GetTasks(DocumentFormat.OpenXml.Packaging.DocumentTasksPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetTasks(DocumentFormat.OpenXml.Packaging.DocumentTasksPart? openXmlElement, DocumentModel.Tasks? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static DocumentModel.Packaging.DocumentTasksPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DocumentTasksPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DocumentTasksPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Tasks = GetTasks(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DocumentTasksPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DocumentTasksPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTasks(openXmlElement, value?.Tasks);
      return openXmlElement;
    }
    return default;
  }
}
