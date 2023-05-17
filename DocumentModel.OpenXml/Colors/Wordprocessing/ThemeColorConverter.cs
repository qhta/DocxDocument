namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.ThemeColor"/> class from/to OpenXml converter.
/// </summary>
public static class ThemeColorConverter
{
  #region ThemeIndex conversion.
  private static DMW.ThemeColorIndex? GetThemeIndex(DXW.ThemeColorValues openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement);
  }
  
  private static bool CmpThemeColorIndex(DXW.ThemeColorValues openXmlElement, DMW.ThemeColorIndex? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement, value, diffs, objName);
  }
  
  private static DXW.ThemeColorValues? CreateThemeColorValues(DMW.ThemeColorIndex value)
  {
    var result = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(value);
    if (result != null) 
      return result.Value;
    return null;
  }
  #endregion

  #region ThemeTint conversion
  private static Percent? GetThemeTint(DXO13W.Color openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXO13W.Color openXmlElement, Percent? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpThemeShade(DXO13W.Color openXmlElement, Percent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "Shade");
  }
  
  private static void SetThemeShade(DXO13W.Color openXmlElement, Percent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

}
