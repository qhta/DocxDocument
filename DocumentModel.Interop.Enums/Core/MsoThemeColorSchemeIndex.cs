namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the color scheme for an Office theme.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msothemecolorschemeindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoThemeColorSchemeIndex")]
public enum ThemeColorSchemeIndex
{
  /// <summary>
  /// Specifies color scheme Dark 1.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeDark1")]
  Dark1 = 1,
  /// <summary>
  /// Specifies color scheme Light 1.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeLight1")]
  Light1,
  /// <summary>
  /// Specifies color scheme Dark 2.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeDark2")]
  Dark2,
  /// <summary>
  /// Specifies color scheme Light 2.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeLight2")]
  Light2,
  /// <summary>
  /// Specifies color scheme Accent 1.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeAccent1")]
  Accent1,
  /// <summary>
  /// Specifies color scheme Accent 2.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeAccent2")]
  Accent2,
  /// <summary>
  /// Specifies color scheme Accent 3.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeAccent3")]
  Accent3,
  /// <summary>
  /// Specifies color scheme Accent 4.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeAccent4")]
  Accent4,
  /// <summary>
  /// Specifies color scheme Accent 5.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeAccent5")]
  Accent5,
  /// <summary>
  /// Specifies color scheme Accent 6.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeAccent6")]
  Accent6,
  /// <summary>
  /// Specifies a color scheme for a hyperlink.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeHyperlink")]
  Hyperlink,
  /// <summary>
  /// Specifies a color scheme for a clicked hyperlink.
  /// </summary>
  [OfficeInteropEnumValue("msoThemeFollowedHyperlink")]
  FollowedHyperlink
}
