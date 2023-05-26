namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public static class DiagramLayoutDefinitionPartConverter
{
  private static String? GetContentType(DXPack.DiagramLayoutDefinitionPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.DiagramLayoutDefinitionPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.DiagramLayoutDefinitionPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.DiagramLayoutDefinitionPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDD.LayoutDefinition? GetLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement)
  {
      return DMXDD.LayoutDefinitionConverter.CreateModelElement(openXmlElement?.RootElement as DXDD.LayoutDefinition);
  }
  
  private static bool CmpLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement, DMDD.LayoutDefinition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement, DMDD.LayoutDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DMXDD.LayoutDefinitionConverter.CreateOpenXmlElement<DXDD.LayoutDefinition>(value);
       if (rootElement != null)
         openXmlElement.LayoutDefinition = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.DiagramLayoutDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DiagramLayoutDefinitionPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.DiagramLayoutDefinitionPart? CreateModelElement(DXPack.DiagramLayoutDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramLayoutDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.LayoutDefinition = GetLayoutDefinition(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DiagramLayoutDefinitionPart? openXmlElement, DMPack.DiagramLayoutDefinitionPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName, propName))
        ok = false;
      if (!CmpLayoutDefinition(openXmlElement, value.LayoutDefinition, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramLayoutDefinitionPart value)
    where OpenXmlElementType: DXPack.DiagramLayoutDefinitionPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.DiagramLayoutDefinitionPart openXmlElement, DMPack.DiagramLayoutDefinitionPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    SetLayoutDefinition(openXmlElement, value?.LayoutDefinition);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
