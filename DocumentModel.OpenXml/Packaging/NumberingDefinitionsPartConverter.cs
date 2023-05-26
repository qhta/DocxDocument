namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the NumberingDefinitionsPart
/// </summary>
public static class NumberingDefinitionsPartConverter
{
  private static String? GetContentType(DXPack.NumberingDefinitionsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.NumberingDefinitionsPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.NumberingDefinitionsPart openXmlElement)
  {
    var collection = new Collection<DMPack.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ImagePart>())
    {
      var newItem = DMXPack.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpImageParts(DXPack.NumberingDefinitionsPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Numbering? GetNumbering(DXPack.NumberingDefinitionsPart openXmlElement)
  {
      return DMXW.NumberingConverter.CreateModelElement(openXmlElement?.RootElement as DXW.Numbering);
  }
  
  private static bool CmpNumbering(DXPack.NumberingDefinitionsPart openXmlElement, DMW.Numbering? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetNumbering(DXPack.NumberingDefinitionsPart openXmlElement, DMW.Numbering? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.NumberingConverter.CreateOpenXmlElement(value);
       if (rootElement != null)
         openXmlElement.Numbering = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.NumberingDefinitionsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.NumberingDefinitionsPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.NumberingDefinitionsPart? CreateModelElement(DXPack.NumberingDefinitionsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.NumberingDefinitionsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Numbering = GetNumbering(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.NumberingDefinitionsPart? openXmlElement, DMPack.NumberingDefinitionsPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName, propName))
        ok = false;
      if (!CmpNumbering(openXmlElement, value.Numbering, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.NumberingDefinitionsPart value)
    where OpenXmlElementType: DXPack.NumberingDefinitionsPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.NumberingDefinitionsPart openXmlElement, DMPack.NumberingDefinitionsPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    SetNumbering(openXmlElement, value?.Numbering);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
