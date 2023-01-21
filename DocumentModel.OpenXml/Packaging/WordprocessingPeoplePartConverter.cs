namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public static class WordprocessingPeoplePartConverter
{
  private static String? GetContentType(DXPack.WordprocessingPeoplePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.People? GetPeople(DXPack.WordprocessingPeoplePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2013W.People rootElement)
      return DMXW.PeopleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetPeople(DXPack.WordprocessingPeoplePart openXmlElement, DMW.People? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.PeopleConverter.CreateOpenXmlElement<DXO2013W.People>(value);
       if (rootElement != null)
         openXmlElement.People = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.WordprocessingPeoplePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WordprocessingPeoplePart? CreateModelElement(DXPack.WordprocessingPeoplePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WordprocessingPeoplePart();
      value.ContentType = GetContentType(openXmlElement);
      value.People = GetPeople(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordprocessingPeoplePart? value)
    where OpenXmlElementType: DXPack.WordprocessingPeoplePart, new()
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
