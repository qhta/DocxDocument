namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the Office theme color.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msothemecolorindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoThemeColorIndex")]
public enum ThemeColorIndex
{
  /// <summary>
  /// Specifies a mixed color theme.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorMixed")]
  ThemeColorMixed = -2,
  /// <summary>
  /// Specifies no theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoNotThemeColor")]
  NotThemeColor = 0,
  /// <summary>
  /// Specifies the Dark 1 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorDark1")]
  ThemeColorDark1 = 1,
  /// <summary>
  /// Specifies the Light 1 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorLight1")]
  ThemeColorLight1 = 2,
  /// <summary>
  /// Specifies the Dark 2 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorDark2")]
  ThemeColorDark2 = 3,
  /// <summary>
  /// Specifies the Light 2 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorLight2")]
  ThemeColorLight2 = 4,
  /// <summary>
  /// Specifies the Accent 1 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorAccent1")]
  ThemeColorAccent1 = 5,
  /// <summary>
  /// Specifies the Accent 2 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorAccent2")]
  ThemeColorAccent2 = 6,
  /// <summary>
  /// Specifies the Accent 3 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorAccent3")]
  ThemeColorAccent3 = 7,
  /// <summary>
  /// Specifies the Accent 4 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorAccent4")]
  ThemeColorAccent4 = 8,
  /// <summary>
  /// Specifies the Accent 5 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorAccent5")]
  ThemeColorAccent5 = 9,
  /// <summary>
  /// Specifies the Accent 6 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorAccent6")]
  ThemeColorAccent6 = 10,
  /// <summary>
  /// Specifies the theme color for a hyperlink.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorHyperlink")]
  ThemeColorHyperlink = 11,
  /// <summary>
  /// Specifies the theme color for a clicked hyperlink.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorFollowedHyperlink")]
  ThemeColorFollowedHyperlink = 12,
  /// <summary>
  /// Specifies the Text 1 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorText1")]
  ThemeColorText1 = 13,
  /// <summary>
  /// Specifies the Background 1 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorBackground1")]
  ThemeColorBackground1 = 14,
  /// <summary>
  /// Specifies the Text 2 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorText2")]
  ThemeColorText2 = 15,
  /// <summary>
  /// Specifies the Background 2 theme color.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeColorBackground2")]
  ThemeColorBackground2 = 16
}
