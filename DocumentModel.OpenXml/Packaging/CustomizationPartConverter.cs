namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public static class CustomizationPartConverter
{
  private static String? GetContentType(DXPack.CustomizationPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.CustomizationPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.CustomizationPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.CustomizationPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.TemplateCommandGroup? GetTemplateCommandGroup(DXPack.CustomizationPart openXmlElement)
  {
      return DMXW.TemplateCommandGroupConverter.CreateModelElement(openXmlElement?.RootElement as DXOW.TemplateCommandGroup);
  }
  
  private static bool CmpTemplateCommandGroup(DXPack.CustomizationPart openXmlElement, DMW.TemplateCommandGroup? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetTemplateCommandGroup(DXPack.CustomizationPart openXmlElement, DMW.TemplateCommandGroup? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.TemplateCommandGroupConverter.CreateOpenXmlElement<DXOW.TemplateCommandGroup>(value);
       if (rootElement != null)
         openXmlElement.TemplateCommandGroup = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.CustomizationPart? CreateModelElement(DXPack.CustomizationPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomizationPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.TemplateCommandGroup = GetTemplateCommandGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.CustomizationPart? openXmlElement, DMPack.CustomizationPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpTemplateCommandGroup(openXmlElement, value.TemplateCommandGroup, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomizationPart value)
    where OpenXmlElementType: DXPack.CustomizationPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.CustomizationPart openXmlElement, DMPack.CustomizationPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetTemplateCommandGroup(openXmlElement, value?.TemplateCommandGroup);
  }
}
