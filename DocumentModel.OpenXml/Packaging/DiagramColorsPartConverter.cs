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
      return DMXDrawsDgms.ColorsDefinitionConverter.CreateModelElement(openXmlElement?.RootElement as DXDrawDgms.ColorsDefinition);
  }
  
  private static bool CmpColorsDefinition(DXPack.DiagramColorsPart openXmlElement, DMDrawsDgms.ColorsDefinition? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpContentType(DXPack.DiagramColorsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.DiagramColorsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DiagramColorsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.DiagramColorsPart? CreateModelElement(DXPack.DiagramColorsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramColorsPart();
      value.ColorsDefinition = GetColorsDefinition(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DiagramColorsPart? openXmlElement, DMPack.DiagramColorsPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorsDefinition(openXmlElement, value.ColorsDefinition, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramColorsPart value)
    where OpenXmlElementType: DXPack.DiagramColorsPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.DiagramColorsPart openXmlElement, DMPack.DiagramColorsPart value)
  {
    SetColorsDefinition(openXmlElement, value?.ColorsDefinition);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
