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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsDgms.LayoutDefinition? GetLayoutDefinition(DXPack.DiagramLayoutDefinitionPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDrawDgms.LayoutDefinition rootElement)
      return DMXDrawsDgms.LayoutDefinitionConverter.CreateModelElement(rootElement);
    return null;
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
