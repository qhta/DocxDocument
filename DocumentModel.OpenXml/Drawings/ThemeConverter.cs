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
  
  private static bool CmpName(DXDraw.Theme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
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
  
  private static bool CmpThemeId(DXDraw.Theme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeId?.Value == value) return true;
    diffs?.Add(objName, "ThemeId", openXmlElement?.ThemeId?.Value, value);
    return false;
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
    return DMXDraws.ThemeElementsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ThemeElements>());
  }
  
  private static bool CmpThemeElements(DXDraw.Theme openXmlElement, DMDraws.ThemeElements? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ThemeElementsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ThemeElements>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ObjectDefaultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ObjectDefaults>());
  }
  
  private static bool CmpObjectDefaults(DXDraw.Theme openXmlElement, DMDraws.ObjectDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ObjectDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ObjectDefaults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ExtraColorSchemeListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtraColorSchemeList>());
  }
  
  private static bool CmpExtraColorSchemeList(DXDraw.Theme openXmlElement, DMDraws.ExtraColorSchemeList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtraColorSchemeListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtraColorSchemeList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.CustomColorListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.CustomColorList>());
  }
  
  private static bool CmpCustomColorList(DXDraw.Theme openXmlElement, DMDraws.CustomColorList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CustomColorList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.OfficeStyleSheetExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.OfficeStyleSheetExtensionList>());
  }
  
  private static bool CmpOfficeStyleSheetExtensionList(DXDraw.Theme openXmlElement, DMDraws.OfficeStyleSheetExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeStyleSheetExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.OfficeStyleSheetExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.Theme? openXmlElement, DMDraws.Theme? value, DiffList? diffs, string? objName)
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
