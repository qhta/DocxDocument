namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
public static class ThemeOverridePartConverter
{
  private static String? GetContentType(DXPack.ThemeOverridePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.ThemeOverridePart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.ThemeOverridePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDraws.ThemeOverride? GetThemeOverride(DXPack.ThemeOverridePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDraw.ThemeOverride rootElement)
      return DMXDraws.ThemeOverrideConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetThemeOverride(DXPack.ThemeOverridePart openXmlElement, DMDraws.ThemeOverride? value)
  {
    if (value != null)
    {
       var rootElement = DMXDraws.ThemeOverrideConverter.CreateOpenXmlElement<DXDraw.ThemeOverride>(value);
       if (rootElement != null)
         openXmlElement.ThemeOverride = rootElement;
    }
  }
  
  public static DMPack.ThemeOverridePart? CreateModelElement(DXPack.ThemeOverridePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ThemeOverridePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.ThemeOverride = GetThemeOverride(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThemeOverridePart? value)
    where OpenXmlElementType: DXPack.ThemeOverridePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetThemeOverride(openXmlElement, value?.ThemeOverride);
      return openXmlElement;
    }
    return default;
  }
}
