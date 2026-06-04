namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the theme colors for document themes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdthemecolorindex?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdThemeColorIndex")]
public enum ThemeColorIndex
{
  /// <summary>
  /// Dark main color 1.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorMainDark1")]
  ThemeColorMainDark1 = 0,
  /// <summary>
  /// Light main color 1.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorMainLight1")]
  ThemeColorMainLight1 = 1,
  /// <summary>
  /// Dark main color 2.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorMainDark2")]
  ThemeColorMainDark2 = 2,
  /// <summary>
  /// Light main color 2.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorMainLight2")]
  ThemeColorMainLight2 = 3,
  /// <summary>
  /// Accent color 1.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorAccent1")]
  ThemeColorAccent1 = 4,
  /// <summary>
  /// Accent color 2.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorAccent2")]
  ThemeColorAccent2 = 5,
  /// <summary>
  /// Accent color 3.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorAccent3")]
  ThemeColorAccent3 = 6,
  /// <summary>
  /// Accent color 4.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorAccent4")]
  ThemeColorAccent4 = 7,
  /// <summary>
  /// Accent color 5.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorAccent5")]
  ThemeColorAccent5 = 8,
  /// <summary>
  /// Accent color 6.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorAccent6")]
  ThemeColorAccent6 = 9,
  /// <summary>
  /// Hyperlink color.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorHyperlink")]
  ThemeColorHyperlink = 10,
  /// <summary>
  /// Followed hyperlink color.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorHyperlinkFollowed")]
  ThemeColorHyperlinkFollowed = 11,
  /// <summary>
  /// Background color 1.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorBackground1")]
  ThemeColorBackground1 = 12,
  /// <summary>
  /// Text color 1.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorText1")]
  ThemeColorText1 = 13,
  /// <summary>
  /// Background color 2.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorBackground2")]
  ThemeColorBackground2 = 14,
  /// <summary>
  /// Text color 2.
  /// </summary>
  [WordInteropEnumValue("wdThemeColorText2")]
  ThemeColorText2 = 15,
  /// <summary>
  /// No color.
  /// </summary>
  [WordInteropEnumValue("wdNotThemeColor")]
  NotThemeColor = -1
}
