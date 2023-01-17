namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public static class WordprocessingPeoplePartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Wordprocessing.People? GetPeople(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.Word.People rootElement)
      return DocumentModel.OpenXml.Wordprocessing.PeopleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetPeople(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart openXmlElement, DocumentModel.Wordprocessing.People? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Wordprocessing.PeopleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.People>(value);
       if (rootElement != null)
         openXmlElement.People = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordprocessingPeoplePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetPeople(openXmlElement, value?.People);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
