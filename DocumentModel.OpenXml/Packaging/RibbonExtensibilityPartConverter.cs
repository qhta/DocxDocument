namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the RibbonExtensibilityPart
/// </summary>
public static class RibbonExtensibilityPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.RibbonExtensibilityPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonExtensibilityPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.RibbonExtensibilityPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.RibbonExtensibilityPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.RibbonExtensibilityPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.RibbonExtensibilityPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.RibbonExtensibilityPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.RibbonExtensibilityPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.RibbonExtensibilityPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
