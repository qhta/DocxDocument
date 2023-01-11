namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public static class OpenXmlPartConverter
{
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public static Uri? GetUri(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the root element of the current part.
  /// </summary>
  public static DocumentModel.ModelElement? GetRootElement(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static DocumentModel.Packaging.OpenXmlPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.OpenXmlPart();
      value.Uri = GetUri(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.RootElement = GetRootElement(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.OpenXmlPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.OpenXmlPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
