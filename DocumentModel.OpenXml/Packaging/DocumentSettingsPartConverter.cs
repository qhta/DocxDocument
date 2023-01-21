namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public static class DocumentSettingsPartConverter
{
  private static String? GetContentType(DXPack.DocumentSettingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.DocumentSettingsPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.DocumentSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Settings? GetSettings(DXPack.DocumentSettingsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXW.Settings rootElement)
      return DMXW.SettingsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetSettings(DXPack.DocumentSettingsPart openXmlElement, DMW.Settings? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.SettingsConverter.CreateOpenXmlElement<DXW.Settings>(value);
       if (rootElement != null)
         openXmlElement.Settings = rootElement;
    }
  }
  
  public static DMPack.DocumentSettingsPart? CreateModelElement(DXPack.DocumentSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DocumentSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Settings = GetSettings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DocumentSettingsPart? value)
    where OpenXmlElementType: DXPack.DocumentSettingsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetSettings(openXmlElement, value?.Settings);
      return openXmlElement;
    }
    return default;
  }
}
