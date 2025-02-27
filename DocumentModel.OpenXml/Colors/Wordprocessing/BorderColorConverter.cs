using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DM.Color"/> model class from/to OpenXml <see cref="DXW.Border"/> class converter.
/// </summary>
public static class BorderColorConverter
{
  #region Color value conversion.
  private static DM.Color? GetVal(DXW.Border openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Color);
  }

  private static bool CmpVal(DXW.Border openXmlElement, DM.Color? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Value");
  }

  private static void SetVal(DXW.Border openXmlElement, DM.Color? value)
  {
    openXmlElement.Color = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeColorIndex conversion.
  private static DMW.ThemeColorIndex? GetThemeColorIndex(DXW.Border openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value);
  }

  private static bool CmpThemeColorIndex(DXW.Border openXmlElement, DMW.ThemeColorIndex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value, value, diffs, objName, propName);
  }

  private static void SetThemeColorIndex(DXW.Border openXmlElement, DMW.ThemeColorIndex? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(value);
  }
  #endregion

  #region ThemeTint conversion
  private static Percent? GetThemeTint(DXW.Border openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }

  private static bool CmpThemeTint(DXW.Border openXmlElement, Percent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "Tint");
  }

  private static void SetThemeTint(DXW.Border openXmlElement, Percent? value)
  {
    openXmlElement.ThemeTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeShade conversion
  private static Percent? GetThemeShade(DXW.Border openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeShade);
  }

  private static bool CmpThemeShade(DXW.Border openXmlElement, Percent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "Shade");
  }

  private static void SetThemeShade(DXW.Border openXmlElement, Percent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Color model conversion.
  public static DM.Color? CreateModelElement(DXW.Border? openXmlElement)
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

  public static bool CompareModelElement(DXW.Border? openXmlElement, DM.Color? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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

  public static void UpdateOpenXmlElement(DXW.Border openXmlElement, DM.Color? value)
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
