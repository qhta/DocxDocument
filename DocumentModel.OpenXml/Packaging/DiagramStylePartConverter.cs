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
  
  private static bool CmpContentType(DXPack.DiagramStylePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.DiagramStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DiagramStylePart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDD.StyleDefinition? GetStyleDefinition(DXPack.DiagramStylePart openXmlElement)
  {
      return DMXDD.StyleDefinitionConverter.CreateModelElement(openXmlElement?.RootElement as DXDD.StyleDefinition);
  }
  
  private static bool CmpStyleDefinition(DXPack.DiagramStylePart openXmlElement, DMDD.StyleDefinition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetStyleDefinition(DXPack.DiagramStylePart openXmlElement, DMDD.StyleDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DMXDD.StyleDefinitionConverter.CreateOpenXmlElement<DXDD.StyleDefinition>(value);
       if (rootElement != null)
         openXmlElement.StyleDefinition = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.DiagramStylePart? CreateModelElement(DXPack.DiagramStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramStylePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.StyleDefinition = GetStyleDefinition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DiagramStylePart? openXmlElement, DMPack.DiagramStylePart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      if (!CmpStyleDefinition(openXmlElement, value.StyleDefinition, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramStylePart value)
    where OpenXmlElementType: DXPack.DiagramStylePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.DiagramStylePart openXmlElement, DMPack.DiagramStylePart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetStyleDefinition(openXmlElement, value?.StyleDefinition);
  }
}
