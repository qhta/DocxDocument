namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public static class WordCommentsExtensiblePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.CommentsExtensible? GetCommentsExtensible(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetCommentsExtensible(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement, DocumentModel.Wordprocessing.CommentsExtensible? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.WordCommentsExtensiblePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordCommentsExtensiblePart();
      value.CommentsExtensible = GetCommentsExtensible(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordCommentsExtensiblePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentsExtensible(openXmlElement, value?.CommentsExtensible);
      return openXmlElement;
    }
    return default;
  }
}
