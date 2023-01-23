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
  
  private static bool CmpContentType(DXPack.DocumentSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
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
  
  private static bool CmpImageParts(DXPack.DocumentSettingsPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.DocumentSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DocumentSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Settings? GetSettings(DXPack.DocumentSettingsPart openXmlElement)
  {
      return DMXW.SettingsConverter.CreateModelElement(openXmlElement?.RootElement as DXW.Settings);
  }
  
  private static bool CmpSettings(DXPack.DocumentSettingsPart openXmlElement, DMW.Settings? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  public static bool CompareModelElement(DXPack.DocumentSettingsPart? openXmlElement, DMPack.DocumentSettingsPart? value, DiffList? diffs, string? objName)
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
      if (!CmpSettings(openXmlElement, value.Settings, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
