namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public static class EmbeddedPackagePartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.EmbeddedPackagePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedPackagePart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.EmbeddedPackagePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
