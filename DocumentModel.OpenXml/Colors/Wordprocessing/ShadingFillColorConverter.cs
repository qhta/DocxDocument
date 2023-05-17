using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DM.Color"/> model class from/to OpenXml <see cref="DXW.Shading"/> class converter using its fill properties.
/// </summary>
public static class ShadingFillColorConverter
{
  #region Color value conversion.
  private static DM.Color? GetVal(DXW.Shading openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Fill);
  }

  private static bool CmpVal(DXW.Shading openXmlElement, DM.Color? value, DiffList? diffs, string? objName)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Fill, value, diffs, objName, "Value");
  }

  private static void SetVal(DXW.Shading openXmlElement, DM.Color? value)
  {
    openXmlElement.Fill = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeColorIndex conversion.
  private static DMW.ThemeColorIndex? GetThemeColorIndex(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeFill?.Value);
  }

  private static bool CmpThemeColorIndex(DXW.Shading openXmlElement, DMW.ThemeColorIndex? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeFill?.Value, value, diffs, objName);
  }

  private static void SetThemeColorIndex(DXW.Shading openXmlElement, DMW.ThemeColorIndex? value)
  {
    openXmlElement.ThemeFill = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(value);
  }
  #endregion

  #region ThemeTint conversion
  private static Percent? GetThemeTint(DXW.Shading openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeFillTint);
  }

  private static bool CmpThemeTint(DXW.Shading openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeFillTint, value, diffs, objName, "Tint");
  }

  private static void SetThemeTint(DXW.Shading openXmlElement, Percent? value)
  {
    openXmlElement.ThemeFillTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeShade conversion
  private static Percent? GetThemeShade(DXW.Shading openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeFillShade);
  }

  private static bool CmpThemeShade(DXW.Shading openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeFillShade, value, diffs, objName, "Shade");
  }

  private static void SetThemeShade(DXW.Shading openXmlElement, Percent? value)
  {
    openXmlElement.ThemeFillShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Color model conversion.
  public static DM.Color? CreateModelElement(DXW.Shading? openXmlElement)
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
        return new DMW.ThemeColor((ThemeColorIndex)themeColor, tint: themeTint, shade: themeShade);
      }
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Shading? openXmlElement, DM.Color? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;

      if (value is DMW.ThemeColor themeColor)
      {
        if (!CmpThemeColorIndex(openXmlElement, themeColor.Index, diffs, objName))
          ok = false;
        if (!CmpThemeTint(openXmlElement, themeColor.Tint, diffs, objName))
          ok = false;
        if (!CmpThemeShade(openXmlElement, themeColor.Shade, diffs, objName))
          ok = false;
      }
      else
      {
        if (!CmpVal(openXmlElement, value, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static void UpdateOpenXmlElement(DXW.Shading openXmlElement, DM.Color? value)
  {
    if (value == null)
    {
      SetVal(openXmlElement, null);
      SetThemeColorIndex(openXmlElement, null);
      SetThemeTint(openXmlElement, null);
      SetThemeShade(openXmlElement, null);
      return;
    }

    if (value is ThemeColor themeColor)
    {
      SetThemeColorIndex(openXmlElement, themeColor.Index);
      SetThemeTint(openXmlElement, themeColor.Tint);
      SetThemeShade(openXmlElement, themeColor.Shade);
    }
    SetVal(openXmlElement, value);
  }
  #endregion
}
