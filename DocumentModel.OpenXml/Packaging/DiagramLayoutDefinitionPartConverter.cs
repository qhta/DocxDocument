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
  
  private static bool CmpContentType(DXPack.DiagramLayoutDefinitionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.DiagramLayoutDefinitionPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.DiagramLayoutDefinitionPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsDgms.LayoutDefinition? GetLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement)
  {
      return DMXDrawsDgms.LayoutDefinitionConverter.CreateModelElement(openXmlElement?.RootElement as DXDrawDgms.LayoutDefinition);
  }
  
  private static bool CmpLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement, DMDrawsDgms.LayoutDefinition? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement, DMDrawsDgms.LayoutDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsDgms.LayoutDefinitionConverter.CreateOpenXmlElement<DXDrawDgms.LayoutDefinition>(value);
       if (rootElement != null)
         openXmlElement.LayoutDefinition = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.DiagramLayoutDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DiagramLayoutDefinitionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.DiagramLayoutDefinitionPart? CreateModelElement(DXPack.DiagramLayoutDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DiagramLayoutDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.LayoutDefinition = GetLayoutDefinition(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DiagramLayoutDefinitionPart? openXmlElement, DMPack.DiagramLayoutDefinitionPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpLayoutDefinition(openXmlElement, value.LayoutDefinition, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramLayoutDefinitionPart? value)
    where OpenXmlElementType: DXPack.DiagramLayoutDefinitionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      SetLayoutDefinition(openXmlElement, value?.LayoutDefinition);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
