namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme.
/// </summary>
public static class ThemeConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXD.Theme openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.Theme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.Theme openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetThemeId(DXD.Theme openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeId);
  }
  
  private static bool CmpThemeId(DXD.Theme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeId, value, diffs, objName, "ThemeId");
  }
  
  private static void SetThemeId(DXD.Theme openXmlElement, String? value)
  {
    openXmlElement.ThemeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  private static DMD.ThemeElements? GetThemeElements(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ThemeElements>();
    if (element != null)
      return DMXD.ThemeElementsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpThemeElements(DXD.Theme openXmlElement, DMD.ThemeElements? value, DiffList? diffs, string? objName)
  {
    return DMXD.ThemeElementsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ThemeElements>(), value, diffs, objName);
  }
  
  private static void SetThemeElements(DXD.Theme openXmlElement, DMD.ThemeElements? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ThemeElements>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ThemeElementsConverter.CreateOpenXmlElement<DXD.ThemeElements>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  private static DMD.ObjectDefaults? GetObjectDefaults(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ObjectDefaults>();
    if (element != null)
      return DMXD.ObjectDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpObjectDefaults(DXD.Theme openXmlElement, DMD.ObjectDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXD.ObjectDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ObjectDefaults>(), value, diffs, objName);
  }
  
  private static void SetObjectDefaults(DXD.Theme openXmlElement, DMD.ObjectDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ObjectDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ObjectDefaultsConverter.CreateOpenXmlElement<DXD.ObjectDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  private static DMD.ExtraColorSchemeList? GetExtraColorSchemeList(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtraColorSchemeList>();
    if (element != null)
      return DMXD.ExtraColorSchemeListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtraColorSchemeList(DXD.Theme openXmlElement, DMD.ExtraColorSchemeList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtraColorSchemeListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtraColorSchemeList>(), value, diffs, objName);
  }
  
  private static void SetExtraColorSchemeList(DXD.Theme openXmlElement, DMD.ExtraColorSchemeList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtraColorSchemeList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtraColorSchemeListConverter.CreateOpenXmlElement<DXD.ExtraColorSchemeList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  private static DMD.CustomColorList? GetCustomColorList(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomColorList>();
    if (element != null)
      return DMXD.CustomColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomColorList(DXD.Theme openXmlElement, DMD.CustomColorList? value, DiffList? diffs, string? objName)
  {
    return DMXD.CustomColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomColorList>(), value, diffs, objName);
  }
  
  private static void SetCustomColorList(DXD.Theme openXmlElement, DMD.CustomColorList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CustomColorListConverter.CreateOpenXmlElement<DXD.CustomColorList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  private static DMD.OfficeStyleSheetExtensionList? GetOfficeStyleSheetExtensionList(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.OfficeStyleSheetExtensionList>();
    if (element != null)
      return DMXD.OfficeStyleSheetExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeStyleSheetExtensionList(DXD.Theme openXmlElement, DMD.OfficeStyleSheetExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.OfficeStyleSheetExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.OfficeStyleSheetExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeStyleSheetExtensionList(DXD.Theme openXmlElement, DMD.OfficeStyleSheetExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.OfficeStyleSheetExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OfficeStyleSheetExtensionListConverter.CreateOpenXmlElement<DXD.OfficeStyleSheetExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Theme? CreateModelElement(DXD.Theme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Theme();
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
  
  public static bool CompareModelElement(DXD.Theme? openXmlElement, DMD.Theme? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpThemeId(openXmlElement, value.ThemeId, diffs, objName))
        ok = false;
      if (!CmpThemeElements(openXmlElement, value.ThemeElements, diffs, objName))
        ok = false;
      if (!CmpObjectDefaults(openXmlElement, value.ObjectDefaults, diffs, objName))
        ok = false;
      if (!CmpExtraColorSchemeList(openXmlElement, value.ExtraColorSchemeList, diffs, objName))
        ok = false;
      if (!CmpCustomColorList(openXmlElement, value.CustomColorList, diffs, objName))
        ok = false;
      if (!CmpOfficeStyleSheetExtensionList(openXmlElement, value.OfficeStyleSheetExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Theme value)
    where OpenXmlElementType: DXD.Theme, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Theme openXmlElement, DMD.Theme value)
  {
    SetName(openXmlElement, value?.Name);
    SetThemeId(openXmlElement, value?.ThemeId);
    SetThemeElements(openXmlElement, value?.ThemeElements);
    SetObjectDefaults(openXmlElement, value?.ObjectDefaults);
    SetExtraColorSchemeList(openXmlElement, value?.ExtraColorSchemeList);
    SetCustomColorList(openXmlElement, value?.CustomColorList);
    SetOfficeStyleSheetExtensionList(openXmlElement, value?.OfficeStyleSheetExtensionList);
  }
}
