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
  
  private static String? GetRelationshipType(DXPack.WebSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.WebSettings? GetWebSettings(DXPack.WebSettingsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXW.WebSettings rootElement)
      return DMXW.WebSettingsConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetWebSettings(DXPack.WebSettingsPart openXmlElement, DMW.WebSettings? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.WebSettingsConverter.CreateOpenXmlElement<DXW.WebSettings>(value);
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
