namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public static class OfficeStyleSheetExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.OfficeStyleSheetExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.OfficeStyleSheetExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DM.ThemeFamily? GetThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013Theme.ThemeFamily>();
    if (itemElement != null)
      return DMX.ThemeFamilyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement, DM.ThemeFamily? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Theme.ThemeFamily>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ThemeFamilyConverter.CreateOpenXmlElement<DXO2013Theme.ThemeFamily>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.OfficeStyleSheetExtension? CreateModelElement(DXDraw.OfficeStyleSheetExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OfficeStyleSheetExtension();
      value.Uri = GetUri(openXmlElement);
      value.ThemeFamily = GetThemeFamily(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OfficeStyleSheetExtension? value)
    where OpenXmlElementType: DXDraw.OfficeStyleSheetExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetThemeFamily(openXmlElement, value?.ThemeFamily);
      return openXmlElement;
    }
    return default;
  }
}
