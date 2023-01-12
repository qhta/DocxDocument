namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public static class VbaDataPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.VbaDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.VbaDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.VbaSuppData? GetVbaSuppData(DocumentFormat.OpenXml.Packaging.VbaDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetVbaSuppData(DocumentFormat.OpenXml.Packaging.VbaDataPart? openXmlElement, DocumentModel.Wordprocessing.VbaSuppData? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static DocumentModel.Packaging.VbaDataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.VbaDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.VbaDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.VbaSuppData = GetVbaSuppData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.VbaDataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.VbaDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVbaSuppData(openXmlElement, value?.VbaSuppData);
      return openXmlElement;
    }
    return default;
  }
}
