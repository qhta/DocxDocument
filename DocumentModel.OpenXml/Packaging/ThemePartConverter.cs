namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public static class ThemePartConverter
{
  private static String? GetContentType(DXPack.ThemePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.ThemePart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.ThemePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDraws.Theme? GetTheme(DXPack.ThemePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDraw.Theme rootElement)
      return DMXDraws.ThemeConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetTheme(DXPack.ThemePart openXmlElement, DMDraws.Theme? value)
  {
    if (value != null)
    {
       var rootElement = DMXDraws.ThemeConverter.CreateOpenXmlElement<DXDraw.Theme>(value);
       if (rootElement != null)
         openXmlElement.Theme = rootElement;
    }
  }
  
  public static DMPack.ThemePart? CreateModelElement(DXPack.ThemePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ThemePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Theme = GetTheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThemePart? value)
    where OpenXmlElementType: DXPack.ThemePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTheme(openXmlElement, value?.Theme);
      return openXmlElement;
    }
    return default;
  }
}
