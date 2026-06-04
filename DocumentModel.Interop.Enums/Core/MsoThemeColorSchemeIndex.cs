namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the color scheme for an Office theme.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msothemecolorschemeindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoThemeColorSchemeIndex))]
public enum ThemeColorSchemeIndex
{
  /// <summary>
  /// Specifies color scheme Dark 1.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeDark1))]
  Dark1 = 1,
  /// <summary>
  /// Specifies color scheme Light 1.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeLight1))]
  Light1,
  /// <summary>
  /// Specifies color scheme Dark 2.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeDark2))]
  Dark2,
  /// <summary>
  /// Specifies color scheme Light 2.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeLight2))]
  Light2,
  /// <summary>
  /// Specifies color scheme Accent 1.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeAccent1))]
  Accent1,
  /// <summary>
  /// Specifies color scheme Accent 2.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeAccent2))]
  Accent2,
  /// <summary>
  /// Specifies color scheme Accent 3.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeAccent3))]
  Accent3,
  /// <summary>
  /// Specifies color scheme Accent 4.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeAccent4))]
  Accent4,
  /// <summary>
  /// Specifies color scheme Accent 5.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeAccent5))]
  Accent5,
  /// <summary>
  /// Specifies color scheme Accent 6.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeAccent6))]
  Accent6,
  /// <summary>
  /// Specifies a color scheme for a hyperlink.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeHyperlink))]
  Hyperlink,
  /// <summary>
  /// Specifies a color scheme for a clicked hyperlink.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoThemeColorSchemeIndex.msoThemeFollowedHyperlink))]
  FollowedHyperlink
}
