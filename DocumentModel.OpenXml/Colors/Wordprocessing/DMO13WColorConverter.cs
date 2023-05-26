namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DM.Color"/> model class from/to OpenXml <see cref="DXO13W.Color"/> class converter.
/// </summary>
public static class DMO13WColorConverter
{
  #region Color value conversion.
  private static DM.Color? GetVal(DXO13W.Color openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXO13W.Color openXmlElement, DM.Color? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXO13W.Color openXmlElement, DM.Color? value)
  {
    openXmlElement.Val = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeColorIndex conversion.
  private static DMW.ThemeColorIndex? GetThemeColorIndex(DXO13W.Color openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColorIndex(DXO13W.Color openXmlElement, DMW.ThemeColorIndex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value, value, diffs, objName, propName);
  }
  
  private static void SetThemeColorIndex(DXO13W.Color openXmlElement, DMW.ThemeColorIndex? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(value);
  }
  #endregion

  #region ThemeTint conversion
  private static Percent? GetThemeTint(DXO13W.Color openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXO13W.Color openXmlElement, Percent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "Tint");
  }
  
  private static void SetThemeTint(DXO13W.Color openXmlElement, Percent? value)
  {
    openXmlElement.ThemeTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeShade conversion
  private static Percent? GetThemeShade(DXO13W.Color openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXO13W.Color openXmlElement, Percent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "Shade");
  }
  
  private static void SetThemeShade(DXO13W.Color openXmlElement, Percent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Color model conversion.
  public static DM.Color? CreateModelElement(DXO13W.Color? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var valModel = GetVal(openXmlElement);
      if (valModel != null)
        return valModel;

      var themeColor = GetThemeColorIndex(openXmlElement);
      if (themeColor != null)
      {
        var themeTint = GetThemeTint(openXmlElement);
        var themeShade = GetThemeShade(openXmlElement);
        return new DMW.ThemeColor((DMW.ThemeColorIndex)themeColor, tint: themeTint, shade: themeShade);
      }
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13W.Color? openXmlElement, DM.Color? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;

      if (value is DMW.ThemeColor themeColor)
      {
        if (!CmpThemeColorIndex(openXmlElement, themeColor.Index, diffs, objName, propName))
          ok = false;
        if (!CmpThemeTint(openXmlElement, themeColor.Tint, diffs, objName, propName))
          ok = false;
        if (!CmpThemeShade(openXmlElement, themeColor.Shade, diffs, objName, propName))
          ok = false;
      }
      else
      {
        if (!CmpVal(openXmlElement, value, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Color value)
    where OpenXmlElementType: DXO13W.Color, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13W.Color openXmlElement, DM.Color value)
  {
    if (value is DMW.ThemeColor themeColor)
    {
      SetThemeColorIndex(openXmlElement, themeColor.Index);
      SetThemeTint(openXmlElement, themeColor.Tint);
      SetThemeShade(openXmlElement, themeColor.Shade);
    }
    SetVal(openXmlElement, value);
  }
  #endregion
}
