namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.Theme"/> class from/to OpenXml converter.
/// </summary>
public static class ThemeConverter
{
  #region Name conversion.
  private static String? GetName(DXD.Theme openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.Theme openXmlElement, String? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, model, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.Theme openXmlElement, String? model)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(model);
  }
  #endregion

  #region ThemeId conversion.
  private static String? GetThemeId(DXD.Theme openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeId);
  }
  
  private static bool CmpThemeId(DXD.Theme openXmlElement, String? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeId, model, diffs, objName, "ThemeId");
  }
  
  private static void SetThemeId(DXD.Theme openXmlElement, String? model)
  {
    openXmlElement.ThemeId = StringValueConverter.CreateStringValue(model);
  }
  #endregion

  #region ThemeElements conversion.
  private static DMD.ThemeElements? GetThemeElements(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ThemeElements>();
    if (element != null)
      return DMXD.ThemeElementsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpThemeElements(DXD.Theme openXmlElement, DMD.ThemeElements? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ThemeElementsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ThemeElements>(), model, diffs, objName, propName);
  }
  
  private static void SetThemeElements(DXD.Theme openXmlElement, DMD.ThemeElements? model)
  {
    var itemElements = openXmlElement.GetFirstChild<DXD.ThemeElements>();
    if (itemElements != null && model != null)
      DMXD.ThemeElementsConverter.UpdateOpenXmlElement(itemElements, model);
    else
    if (model != null)
    {
      itemElements = DMXD.ThemeElementsConverter.CreateOpenXmlElement(model);
      if (itemElements != null)
        openXmlElement.AppendChild(itemElements);
    }
  }
  #endregion

  #region ObjectDefaults conversion.
  private static DMD.ObjectDefaults? GetObjectDefaults(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ObjectDefaults>();
    if (element != null)
      return DMXD.ObjectDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpObjectDefaults(DXD.Theme openXmlElement, DMD.ObjectDefaults? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ObjectDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ObjectDefaults>(), model, diffs, objName, propName);
  }
  
  private static void SetObjectDefaults(DXD.Theme openXmlElement, DMD.ObjectDefaults? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ObjectDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.ObjectDefaultsConverter.CreateOpenXmlElement<DXD.ObjectDefaults>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ExtraColorSchemeList conversion.
  private static DMD.ExtraColorSchemeList? GetExtraColorSchemeList(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtraColorSchemeList>();
    if (element != null)
      return DMXD.ExtraColorSchemeListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtraColorSchemeList(DXD.Theme openXmlElement, DMD.ExtraColorSchemeList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtraColorSchemeListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtraColorSchemeList>(), model, diffs, objName, propName);
  }
  
  private static void SetExtraColorSchemeList(DXD.Theme openXmlElement, DMD.ExtraColorSchemeList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtraColorSchemeList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.ExtraColorSchemeListConverter.CreateOpenXmlElement<DXD.ExtraColorSchemeList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region CustomColorList conversion.
  private static DMD.CustomColorList? GetCustomColorList(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomColorList>();
    if (element != null)
      return DMXD.CustomColorListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomColorList(DXD.Theme openXmlElement, DMD.CustomColorList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomColorListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomColorList>(), model, diffs, objName, propName);
  }
  
  private static void SetCustomColorList(DXD.Theme openXmlElement, DMD.CustomColorList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomColorList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.CustomColorListConverter.CreateOpenXmlElement<DXD.CustomColorList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region OfficeStyleSheetExtensionList conversion.
  private static DMD.OfficeStyleSheetExtensionList? GetOfficeStyleSheetExtensionList(DXD.Theme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.OfficeStyleSheetExtensionList>();
    if (element != null)
      return DMXD.OfficeStyleSheetExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeStyleSheetExtensionList(DXD.Theme openXmlElement, DMD.OfficeStyleSheetExtensionList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.OfficeStyleSheetExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.OfficeStyleSheetExtensionList>(), model, diffs, objName, propName);
  }
  
  private static void SetOfficeStyleSheetExtensionList(DXD.Theme openXmlElement, DMD.OfficeStyleSheetExtensionList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.OfficeStyleSheetExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.OfficeStyleSheetExtensionListConverter.CreateOpenXmlElement<DXD.OfficeStyleSheetExtensionList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Theme model conversion.
  public static DMD.Theme? CreateModelElement(DXD.Theme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.Theme();
      model.Name = GetName(openXmlElement);
      model.ThemeId = GetThemeId(openXmlElement);
      model.ThemeElements = GetThemeElements(openXmlElement);
      model.ObjectDefaults = GetObjectDefaults(openXmlElement);
      model.ExtraColorSchemeList = GetExtraColorSchemeList(openXmlElement);
      model.CustomColorList = GetCustomColorList(openXmlElement);
      model.OfficeStyleSheetExtensionList = GetOfficeStyleSheetExtensionList(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Theme? openXmlElement, DMD.Theme? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, model.Name, diffs, objName, propName))
        ok = false;
      if (!CmpThemeId(openXmlElement, model.ThemeId, diffs, objName, propName))
        ok = false;
      if (!CmpThemeElements(openXmlElement, model.ThemeElements, diffs, objName, propName))
        ok = false;
      if (!CmpObjectDefaults(openXmlElement, model.ObjectDefaults, diffs, objName, propName))
        ok = false;
      if (!CmpExtraColorSchemeList(openXmlElement, model.ExtraColorSchemeList, diffs, objName, propName))
        ok = false;
      if (!CmpCustomColorList(openXmlElement, model.CustomColorList, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeStyleSheetExtensionList(openXmlElement, model.OfficeStyleSheetExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXD.Theme CreateOpenXmlElement(DMD.Theme model)
  {
    var openXmlElement = new DXD.Theme();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Theme openXmlElement, DMD.Theme model)
  {
    SetName(openXmlElement, model.Name);
    SetThemeId(openXmlElement, model.ThemeId);
    SetThemeElements(openXmlElement, model.ThemeElements);
    SetObjectDefaults(openXmlElement, model.ObjectDefaults);
    SetExtraColorSchemeList(openXmlElement, model.ExtraColorSchemeList);
    SetCustomColorList(openXmlElement, model.CustomColorList);
    SetOfficeStyleSheetExtensionList(openXmlElement, model.OfficeStyleSheetExtensionList);
  }
  #endregion
}
