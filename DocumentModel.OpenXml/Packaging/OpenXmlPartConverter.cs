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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the root element of the current part.
  /// </summary>
  public static DocumentModel.ModelElement? GetRootElement(DocumentFormat.OpenXml.Packaging.OpenXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
}
