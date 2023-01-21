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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Fonts? GetFonts(DXPack.FontTablePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXW.Fonts rootElement)
      return DMXW.FontsConverter.CreateModelElement(rootElement);
    return null;
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
