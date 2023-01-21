namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public static class DiagramStylePartConverter
{
  private static String? GetContentType(DXPack.DiagramStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.DiagramStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsDgms.StyleDefinition? GetStyleDefinition(DXPack.DiagramStylePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDrawDgms.StyleDefinition rootElement)
      return DMXDrawsDgms.StyleDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetStyleDefinition(DXPack.DiagramStylePart openXmlElement, DMDrawsDgms.StyleDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsDgms.StyleDefinitionConverter.CreateOpenXmlElement<DXDrawDgms.StyleDefinition>(value);
       if (rootElement != null)
         openXmlElement.StyleDefinition = rootElement;
    }
  }
  
  public static DMPack.DiagramStylePart? CreateModelElement(DXPack.DiagramStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DiagramStylePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.StyleDefinition = GetStyleDefinition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramStylePart? value)
    where OpenXmlElementType: DXPack.DiagramStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetStyleDefinition(openXmlElement, value?.StyleDefinition);
      return openXmlElement;
    }
    return default;
  }
}
