namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the color scheme for an Office theme.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msothemecolorschemeindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoThemeColorSchemeIndex")]
public enum ThemeColorSchemeIndex
{
  /// <summary>
  /// Specifies color scheme Dark 1.
  /// </summary>
  [InteropEnumValue("msoThemeDark1")]
  Dark1 = 1,
  /// <summary>
  /// Specifies color scheme Light 1.
  /// </summary>
  [InteropEnumValue("msoThemeLight1")]
  Light1,
  /// <summary>
  /// Specifies color scheme Dark 2.
  /// </summary>
  [InteropEnumValue("msoThemeDark2")]
  Dark2,
  /// <summary>
  /// Specifies color scheme Light 2.
  /// </summary>
  [InteropEnumValue("msoThemeLight2")]
  Light2,
  /// <summary>
  /// Specifies color scheme Accent 1.
  /// </summary>
  [InteropEnumValue("msoThemeAccent1")]
  Accent1,
  /// <summary>
  /// Specifies color scheme Accent 2.
  /// </summary>
  [InteropEnumValue("msoThemeAccent2")]
  Accent2,
  /// <summary>
  /// Specifies color scheme Accent 3.
  /// </summary>
  [InteropEnumValue("msoThemeAccent3")]
  Accent3,
  /// <summary>
  /// Specifies color scheme Accent 4.
  /// </summary>
  [InteropEnumValue("msoThemeAccent4")]
  Accent4,
  /// <summary>
  /// Specifies color scheme Accent 5.
  /// </summary>
  [InteropEnumValue("msoThemeAccent5")]
  Accent5,
  /// <summary>
  /// Specifies color scheme Accent 6.
  /// </summary>
  [InteropEnumValue("msoThemeAccent6")]
  Accent6,
  /// <summary>
  /// Specifies a color scheme for a hyperlink.
  /// </summary>
  [InteropEnumValue("msoThemeHyperlink")]
  Hyperlink,
  /// <summary>
  /// Specifies a color scheme for a clicked hyperlink.
  /// </summary>
  [InteropEnumValue("msoThemeFollowedHyperlink")]
  FollowedHyperlink
}
