using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the WordprocessingPeoplePart
/// </summary>
public static class WordprocessingPeoplePartConverter
{
  public static String? GetContentType(WordprocessingPeoplePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static People? GetPeople(WordprocessingPeoplePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.Word.People rootElement)
      return PeopleConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetPeople(WordprocessingPeoplePart? openXmlElement, People? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = PeopleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.People>(value);
        if (rootElement != null)
          openXmlElement.People = rootElement;
      }
  }

  public static String? GetRelationshipType(WordprocessingPeoplePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.WordprocessingPeoplePart? CreateModelElement(WordprocessingPeoplePart? openXmlElement)
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
    where OpenXmlElementType : WordprocessingPeoplePart, new()
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