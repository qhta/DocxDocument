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
  
  private static String? GetRelationshipType(DXPack.CustomizationPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.TemplateCommandGroup? GetTemplateCommandGroup(DXPack.CustomizationPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXOW.TemplateCommandGroup rootElement)
      return DMXW.TemplateCommandGroupConverter.CreateModelElement(rootElement);
    return null;
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
  
  public static DMPack.CustomizationPart? CreateModelElement(DXPack.CustomizationPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomizationPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.TemplateCommandGroup = GetTemplateCommandGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomizationPart? value)
    where OpenXmlElementType: DXPack.CustomizationPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTemplateCommandGroup(openXmlElement, value?.TemplateCommandGroup);
      return openXmlElement;
    }
    return default;
  }
}
