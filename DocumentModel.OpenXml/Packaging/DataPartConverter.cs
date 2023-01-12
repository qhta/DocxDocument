namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents the type of part referenced by a .
/// </summary>
public static class DataPartConverter
{
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public static Uri? GetUri(DocumentFormat.OpenXml.Packaging.DataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the data in the part.
  /// </summary>
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.DataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DataPart();
      value.Uri = GetUri(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
