namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public static class FontTablePartConverter
{
  private static String? GetContentType(DXPack.FontTablePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.FontTablePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  private static Collection<DMPack.FontPart> GetFontParts(DXPack.FontTablePart openXmlElement)
  {
    var collection = new Collection<DMPack.FontPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.FontPart>())
    {
      var newItem = DMXPack.FontPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpFontParts(DXPack.FontTablePart openXmlElement, Collection<DMPack.FontPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Fonts? GetFonts(DXPack.FontTablePart openXmlElement)
  {
      return DMXW.FontsConverter.CreateModelElement(openXmlElement?.RootElement as DXW.Fonts);
  }
  
  private static bool CmpFonts(DXPack.FontTablePart openXmlElement, DMW.Fonts? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetFonts(DXPack.FontTablePart openXmlElement, DMW.Fonts? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.FontsConverter.CreateOpenXmlElement<DXW.Fonts>(value);
       if (rootElement != null)
         openXmlElement.Fonts = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DXPack.FontTablePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.FontTablePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.FontTablePart? CreateModelElement(DXPack.FontTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.FontTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.FontParts = GetFontParts(openXmlElement);
      value.Fonts = GetFonts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.FontTablePart? openXmlElement, DMPack.FontTablePart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpFontParts(openXmlElement, value.FontParts, diffs, objName))
        ok = false;
      if (!CmpFonts(openXmlElement, value.Fonts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.FontTablePart? value)
    where OpenXmlElementType: DXPack.FontTablePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetFontParts(openXmlElement, value?.FontParts);
      SetFonts(openXmlElement, value?.Fonts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
