namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public static class WebSettingsPartConverter
{
  private static String? GetContentType(DXPack.WebSettingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.WebSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.WebSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WebSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DM.WebSettings? GetWebSettings(DXPack.WebSettingsPart openXmlElement)
  {
      return DMX.WebSettingsConverter.CreateModelElement(openXmlElement?.RootElement as DXW.WebSettings);
  }
  
  private static bool CmpWebSettings(DXPack.WebSettingsPart openXmlElement, DM.WebSettings? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetWebSettings(DXPack.WebSettingsPart openXmlElement, DM.WebSettings? value)
  {
    if (value != null)
    {
       var rootElement = DMX.WebSettingsConverter.CreateOpenXmlElement<DXW.WebSettings>(value);
       if (rootElement != null)
         openXmlElement.WebSettings = rootElement;
    }
  }
  
  public static DMPack.WebSettingsPart? CreateModelElement(DXPack.WebSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WebSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebSettings = GetWebSettings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.WebSettingsPart? openXmlElement, DMPack.WebSettingsPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpWebSettings(openXmlElement, value.WebSettings, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WebSettingsPart? value)
    where OpenXmlElementType: DXPack.WebSettingsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetWebSettings(openXmlElement, value?.WebSettings);
      return openXmlElement;
    }
    return default;
  }
}
