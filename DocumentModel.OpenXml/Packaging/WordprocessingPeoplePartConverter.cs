namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public static class WordprocessingPeoplePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.People? GetPeople(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetPeople(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart? openXmlElement, DocumentModel.Wordprocessing.People? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.WordprocessingPeoplePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordprocessingPeoplePart();
      value.ContentType = GetContentType(openXmlElement);
      value.People = GetPeople(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordprocessingPeoplePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
