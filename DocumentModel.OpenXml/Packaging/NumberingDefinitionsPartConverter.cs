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
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.NumberingDefinitionsPart openXmlElement)
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
  private static DMW.Numbering? GetNumbering(DXPack.NumberingDefinitionsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXW.Numbering rootElement)
      return DMXW.NumberingConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetNumbering(DXPack.NumberingDefinitionsPart openXmlElement, DMW.Numbering? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.NumberingConverter.CreateOpenXmlElement<DXW.Numbering>(value);
       if (rootElement != null)
         openXmlElement.Numbering = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.NumberingDefinitionsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.NumberingDefinitionsPart? CreateModelElement(DXPack.NumberingDefinitionsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.NumberingDefinitionsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Numbering = GetNumbering(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.NumberingDefinitionsPart? value)
    where OpenXmlElementType: DXPack.NumberingDefinitionsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      SetNumbering(openXmlElement, value?.Numbering);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
