using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DM.Color"/> model class from/to OpenXml <see cref="DXW.Color"/> class converter.
/// </summary>
public static class ColorConverter
{
  #region RGB Color conversion.
  private static DM.Color? GetVal(DXW.Color openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Val);
  }

  private static bool CmpVal(DXW.Color openXmlElement, DM.Color? value, DiffList? diffs, string? objName)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }

  private static void SetVal(DXW.Color openXmlElement, DM.Color? value)
  {
    openXmlElement.Val = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeColorIndex conversion.
  private static DMW.ThemeColorIndex? GetThemeColorIndex(DXW.Color openXmlElement)
  {
    if (openXmlElement == null)
      return null;
    if (openXmlElement.ThemeColor == null)
      return null;
    var themeColor = openXmlElement?.ThemeColor?.Value;
    if (themeColor != null)
      return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value);
    return null;
  }

  private static bool CmpThemeColorIndex(DXW.Color openXmlElement, DMW.ThemeColorIndex? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value, value, diffs, objName);
  }

  private static void SetThemeColorIndex(DXW.Color openXmlElement, DMW.ThemeColorIndex? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(value);
  }
  #endregion

  #region ThemeTint conversion
  private static Percent? GetThemeTint(DXW.Color openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }

  private static bool CmpThemeTint(DXW.Color openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "Tint");
  }

  private static void SetThemeTint(DXW.Color openXmlElement, Percent? value)
  {
    openXmlElement.ThemeTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeShade conversion
  private static Percent? GetThemeShade(DXW.Color openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeShade);
  }

  private static bool CmpThemeShade(DXW.Color openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "Shade");
  }

  private static void SetThemeShade(DXW.Color openXmlElement, Percent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Color model conversion.
  public static DM.Color? CreateModelElement(DXW.Color? openXmlElement)
  {
    if (openXmlElement != null)
    {

      var valModel = GetVal(openXmlElement);

      var themeColor = GetThemeColorIndex(openXmlElement);
      if (themeColor != null)
      {
        var themeTint = GetThemeTint(openXmlElement);
        var themeShade = GetThemeShade(openXmlElement);

        var model = new DMW.ThemeColor((ThemeColorIndex)themeColor, tint: themeTint, shade: themeShade);
        if (valModel != null)
        {
          model.Name = valModel.Name;
          model.Value = valModel.Value;
        }
        return model;
      }
      if (valModel != null)
        return valModel;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Color? openXmlElement, DM.Color? value, DiffList? diffs, string? objName)
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Color value)
    where OpenXmlElementType : DXW.Color, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Color openXmlElement, DM.Color value)
  {
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
