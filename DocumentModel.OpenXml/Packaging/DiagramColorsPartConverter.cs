namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public static class DiagramColorsPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsDgms.ColorsDefinition? GetColorsDefinition(DXPack.DiagramColorsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDrawDgms.ColorsDefinition rootElement)
      return DMXDrawsDgms.ColorsDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetColorsDefinition(DXPack.DiagramColorsPart openXmlElement, DMDrawsDgms.ColorsDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsDgms.ColorsDefinitionConverter.CreateOpenXmlElement<DXDrawDgms.ColorsDefinition>(value);
       if (rootElement != null)
         openXmlElement.ColorsDefinition = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.DiagramColorsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.DiagramColorsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.DiagramColorsPart? CreateModelElement(DXPack.DiagramColorsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DiagramColorsPart();
      value.ColorsDefinition = GetColorsDefinition(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramColorsPart? value)
    where OpenXmlElementType: DXPack.DiagramColorsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorsDefinition(openXmlElement, value?.ColorsDefinition);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
