namespace DocumentModel.Drawings;

/// <summary>
/// Indicates the Office theme color.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msothemecolorindex?view=office-pia` for Office interop details.
/// </remarks>
public enum ThemeColorIndex
{
  /// <summary>
  /// Specifies a mixed color theme.
  /// </summary>
  ThemeColorMixed = -2,
  /// <summary>
  /// Specifies no theme color.
  /// </summary>
  NotThemeColor = 0,
  /// <summary>
  /// Specifies the Dark 1 theme color.
  /// </summary>
  ThemeColorDark1 = 1,
  /// <summary>
  /// Specifies the Light 1 theme color.
  /// </summary>
  ThemeColorLight1 = 2,
  /// <summary>
  /// Specifies the Dark 2 theme color.
  /// </summary>
  ThemeColorDark2 = 3,
  /// <summary>
  /// Specifies the Light 2 theme color.
  /// </summary>
  ThemeColorLight2 = 4,
  /// <summary>
  /// Specifies the Accent 1 theme color.
  /// </summary>
  ThemeColorAccent1 = 5,
  /// <summary>
  /// Specifies the Accent 2 theme color.
  /// </summary>
  ThemeColorAccent2 = 6,
  /// <summary>
  /// Specifies the Accent 3 theme color.
  /// </summary>
  ThemeColorAccent3 = 7,
  /// <summary>
  /// Specifies the Accent 4 theme color.
  /// </summary>
  ThemeColorAccent4 = 8,
  /// <summary>
  /// Specifies the Accent 5 theme color.
  /// </summary>
  ThemeColorAccent5 = 9,
  /// <summary>
  /// Specifies the Accent 6 theme color.
  /// </summary>
  ThemeColorAccent6 = 10,
  /// <summary>
  /// Specifies the theme color for a hyperlink.
  /// </summary>
  ThemeColorHyperlink = 11,
  /// <summary>
  /// Specifies the theme color for a clicked hyperlink.
  /// </summary>
  ThemeColorFollowedHyperlink = 12,
  /// <summary>
  /// Specifies the Text 1 theme color.
  /// </summary>
  ThemeColorText1 = 13,
  /// <summary>
  /// Specifies the Background 1 theme color.
  /// </summary>
  ThemeColorBackground1 = 14,
  /// <summary>
  /// Specifies the Text 2 theme color.
  /// </summary>
  ThemeColorText2 = 15,
  /// <summary>
  /// Specifies the Background 2 theme color.
  /// </summary>
  ThemeColorBackground2 = 16
}
