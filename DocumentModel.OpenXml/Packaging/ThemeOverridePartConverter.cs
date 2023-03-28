namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThemeOverridePar converter from/to OpenXml.
///</summary>
public static class ThemeOverridePartConverter
{
  private static String? GetContentType(DXPack.ThemeOverridePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ThemeOverridePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.ThemeOverridePart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.ThemeOverridePart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.ThemeOverridePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ThemeOverridePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDraws.ThemeOverride? GetThemeOverride(DXPack.ThemeOverridePart openXmlElement)
  {
      return DMXDraws.ThemeOverrideConverter.CreateModelElement(openXmlElement?.RootElement as DXDraw.ThemeOverride);
  }
  
  private static bool CmpThemeOverride(DXPack.ThemeOverridePart openXmlElement, DMDraws.ThemeOverride? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  public static DocumentModel.Packaging.ThemeOverridePart? CreateModelElement(DXPack.ThemeOverridePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThemeOverridePart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.ThemeOverride = GetThemeOverride(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ThemeOverridePart? openXmlElement, DMPack.ThemeOverridePart? value, DiffList? diffs, string? objName)
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
      if (!CmpThemeOverride(openXmlElement, value.ThemeOverride, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThemeOverridePart value)
    where OpenXmlElementType: DXPack.ThemeOverridePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ThemeOverridePart openXmlElement, DMPack.ThemeOverridePart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetThemeOverride(openXmlElement, value?.ThemeOverride);
  }
}
