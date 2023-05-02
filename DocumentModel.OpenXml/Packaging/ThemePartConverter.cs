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
  
  private static bool CmpContentType(DXPack.ThemePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.ThemePart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.ThemePart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.ThemePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ThemePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMD.Theme? GetTheme(DXPack.ThemePart openXmlElement)
  {
      return DMXD.ThemeConverter.CreateModelElement(openXmlElement?.RootElement as DXD.Theme);
  }
  
  private static bool CmpTheme(DXPack.ThemePart openXmlElement, DMD.Theme? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetTheme(DXPack.ThemePart openXmlElement, DMD.Theme? value)
  {
    if (value != null)
    {
       var rootElement = DMXD.ThemeConverter.CreateOpenXmlElement(value);
       if (rootElement != null)
         openXmlElement.Theme = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.ThemePart? CreateModelElement(DXPack.ThemePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThemePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Theme = GetTheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ThemePart? openXmlElement, DMPack.ThemePart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpTheme(openXmlElement, value.Theme, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThemePart value)
    where OpenXmlElementType: DXPack.ThemePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ThemePart openXmlElement, DMPack.ThemePart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetTheme(openXmlElement, value?.Theme);
  }
}
