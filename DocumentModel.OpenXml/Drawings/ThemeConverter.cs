namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme.
/// </summary>
public static class ThemeConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXDraw.Theme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDraw.Theme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetThemeId(DXDraw.Theme openXmlElement)
  {
    return openXmlElement?.ThemeId?.Value;
  }
  
  private static void SetThemeId(DXDraw.Theme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeId = new StringValue { Value = value };
    else
      openXmlElement.ThemeId = null;
  }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  private static DMDraws.ThemeElements? GetThemeElements(DXDraw.Theme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ThemeElements>();
    if (itemElement != null)
      return DMXDraws.ThemeElementsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetThemeElements(DXDraw.Theme openXmlElement, DMDraws.ThemeElements? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ThemeElements>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ThemeElementsConverter.CreateOpenXmlElement<DXDraw.ThemeElements>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  private static DMDraws.ObjectDefaults? GetObjectDefaults(DXDraw.Theme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ObjectDefaults>();
    if (itemElement != null)
      return DMXDraws.ObjectDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetObjectDefaults(DXDraw.Theme openXmlElement, DMDraws.ObjectDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ObjectDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ObjectDefaultsConverter.CreateOpenXmlElement<DXDraw.ObjectDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  private static DMDraws.ExtraColorSchemeList? GetExtraColorSchemeList(DXDraw.Theme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtraColorSchemeList>();
    if (itemElement != null)
      return DMXDraws.ExtraColorSchemeListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtraColorSchemeList(DXDraw.Theme openXmlElement, DMDraws.ExtraColorSchemeList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtraColorSchemeList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtraColorSchemeListConverter.CreateOpenXmlElement<DXDraw.ExtraColorSchemeList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  private static DMDraws.CustomColorList? GetCustomColorList(DXDraw.Theme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.CustomColorList>();
    if (itemElement != null)
      return DMXDraws.CustomColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomColorList(DXDraw.Theme openXmlElement, DMDraws.CustomColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CustomColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CustomColorListConverter.CreateOpenXmlElement<DXDraw.CustomColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  private static DMDraws.OfficeStyleSheetExtensionList? GetOfficeStyleSheetExtensionList(DXDraw.Theme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.OfficeStyleSheetExtensionList>();
    if (itemElement != null)
      return DMXDraws.OfficeStyleSheetExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeStyleSheetExtensionList(DXDraw.Theme openXmlElement, DMDraws.OfficeStyleSheetExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.OfficeStyleSheetExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OfficeStyleSheetExtensionListConverter.CreateOpenXmlElement<DXDraw.OfficeStyleSheetExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Theme? CreateModelElement(DXDraw.Theme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Theme();
      value.Name = GetName(openXmlElement);
      value.ThemeId = GetThemeId(openXmlElement);
      value.ThemeElements = GetThemeElements(openXmlElement);
      value.ObjectDefaults = GetObjectDefaults(openXmlElement);
      value.ExtraColorSchemeList = GetExtraColorSchemeList(openXmlElement);
      value.CustomColorList = GetCustomColorList(openXmlElement);
      value.OfficeStyleSheetExtensionList = GetOfficeStyleSheetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Theme? value)
    where OpenXmlElementType: DXDraw.Theme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetThemeId(openXmlElement, value?.ThemeId);
      SetThemeElements(openXmlElement, value?.ThemeElements);
      SetObjectDefaults(openXmlElement, value?.ObjectDefaults);
      SetExtraColorSchemeList(openXmlElement, value?.ExtraColorSchemeList);
      SetCustomColorList(openXmlElement, value?.CustomColorList);
      SetOfficeStyleSheetExtensionList(openXmlElement, value?.OfficeStyleSheetExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
