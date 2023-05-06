namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.DocumentBackground"/> class from/to OpenXml converter.
/// </summary>
public static class DocumentBackgroundConverter
{
  #region RGB Color conversion.
  private static RGB? GetVal(DXW.DocumentBackground openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpVal(DXW.DocumentBackground openXmlElement, RGB? value, DiffList? diffs, string? objName)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetVal(DXW.DocumentBackground openXmlElement, RGB? value)
  {
    openXmlElement.Color = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeColor conversion.
  private static DMW.ThemeColorKind? GetThemeColor(DXW.DocumentBackground openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColor(DXW.DocumentBackground openXmlElement, DMW.ThemeColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName);
  }
  
  private static void SetThemeColor(DXW.DocumentBackground openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  #endregion

  #region ThemeTint conversion
  private static Percent? GetThemeTint(DXW.DocumentBackground openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.DocumentBackground openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXW.DocumentBackground openXmlElement, Percent? value)
  {
    openXmlElement.ThemeTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeShade conversion
  private static Percent? GetThemeShade(DXW.DocumentBackground openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.DocumentBackground openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXW.DocumentBackground openXmlElement, Percent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Color properties conversion.
  public static DMW.Color? GetColor(DXW.DocumentBackground? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Color();
      value.RGB = GetVal(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CmpColor(DXW.DocumentBackground? openXmlElement, DMW.Color? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.RGB, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ThemeShade, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static void SetColor(DXW.DocumentBackground openXmlElement, DMW.Color? value)
  {
    if (value!=null)
      UpdateColor(openXmlElement, value);
    else
    {
      openXmlElement.Color = null;
      openXmlElement.ThemeColor = null;
      openXmlElement.ThemeTint = null;
      openXmlElement.ThemeShade = null;
    }
  }
  
  public static void UpdateColor(DXW.DocumentBackground openXmlElement, DMW.Color value)
  {
    SetVal(openXmlElement, value.RGB);
    SetThemeColor(openXmlElement, value.ThemeColor);
    SetThemeTint(openXmlElement, value.ThemeTint);
    SetThemeShade(openXmlElement, value.ThemeShade);
  }
  #endregion

  #region Background conversion.
  private static DMV.Background? GetBackground(DXW.DocumentBackground openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Background>();
    if (element != null)
      return DMXV.BackgroundConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackground(DXW.DocumentBackground openXmlElement, DMV.Background? value, DiffList? diffs, string? objName)
  {
    return DMXV.BackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Background>(), value, diffs, objName);
  }
  
  private static void SetBackground(DXW.DocumentBackground openXmlElement, DMV.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.BackgroundConverter.CreateOpenXmlElement<DXV.Background>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
#endregion

  public static DMW.DocumentBackground? CreateModelElement(DXW.DocumentBackground? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.DocumentBackground();
      model.Color = GetColor(openXmlElement);
      model.Background = GetBackground(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocumentBackground? openXmlElement, DMW.DocumentBackground? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpColor(openXmlElement, model.Color, diffs, objName))
        ok = false;
      if (!CmpBackground(openXmlElement, model.Background, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.DocumentBackground CreateOpenXmlElement(DMW.DocumentBackground model)
  {
    var openXmlElement = new DXW.DocumentBackground();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocumentBackground openXmlElement, DMW.DocumentBackground model)
  {
    SetColor(openXmlElement, model.Color);
    SetBackground(openXmlElement, model.Background);
  }
}
