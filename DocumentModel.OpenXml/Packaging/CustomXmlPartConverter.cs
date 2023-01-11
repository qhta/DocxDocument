namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
public static class CustomXmlPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomXmlPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.CustomXmlPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CustomXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomXmlPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomXmlPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CustomXmlPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
