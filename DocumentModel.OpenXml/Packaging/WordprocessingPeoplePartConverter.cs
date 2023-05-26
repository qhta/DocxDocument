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
  
  private static bool CmpContentType(DXPack.WordprocessingPeoplePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.People? GetPeople(DXPack.WordprocessingPeoplePart openXmlElement)
  {
      return DMXW.PeopleConverter.CreateModelElement(openXmlElement?.RootElement as DXO13W.People);
  }
  
  private static bool CmpPeople(DXPack.WordprocessingPeoplePart openXmlElement, DMW.People? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetPeople(DXPack.WordprocessingPeoplePart openXmlElement, DMW.People? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.PeopleConverter.CreateOpenXmlElement<DXO13W.People>(value);
       if (rootElement != null)
         openXmlElement.People = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.WordprocessingPeoplePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WordprocessingPeoplePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.WordprocessingPeoplePart? CreateModelElement(DXPack.WordprocessingPeoplePart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.WordprocessingPeoplePart? openXmlElement, DMPack.WordprocessingPeoplePart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpPeople(openXmlElement, value.People, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordprocessingPeoplePart value)
    where OpenXmlElementType: DXPack.WordprocessingPeoplePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.WordprocessingPeoplePart openXmlElement, DMPack.WordprocessingPeoplePart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    SetPeople(openXmlElement, value?.People);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
