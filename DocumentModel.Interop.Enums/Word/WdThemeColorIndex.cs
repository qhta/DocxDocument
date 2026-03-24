namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the theme colors for document themes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdthemecolorindex?view=office-pia` for Office interop details.
/// </remarks>
public enum WdThemeColorIndex
{
  /// <summary>
  /// Dark main color 1.
  /// </summary>
  ThemeColorMainDark1 = 0,
  /// <summary>
  /// Light main color 1.
  /// </summary>
  ThemeColorMainLight1 = 1,
  /// <summary>
  /// Dark main color 2.
  /// </summary>
  ThemeColorMainDark2 = 2,
  /// <summary>
  /// Light main color 2.
  /// </summary>
  ThemeColorMainLight2 = 3,
  /// <summary>
  /// Accent color 1.
  /// </summary>
  ThemeColorAccent1 = 4,
  /// <summary>
  /// Accent color 2.
  /// </summary>
  ThemeColorAccent2 = 5,
  /// <summary>
  /// Accent color 3.
  /// </summary>
  ThemeColorAccent3 = 6,
  /// <summary>
  /// Accent color 4.
  /// </summary>
  ThemeColorAccent4 = 7,
  /// <summary>
  /// Accent color 5.
  /// </summary>
  ThemeColorAccent5 = 8,
  /// <summary>
  /// Accent color 6.
  /// </summary>
  ThemeColorAccent6 = 9,
  /// <summary>
  /// Specifies the theme colors for document themes.
  /// </summary>
  ThemeColorHyperlink = 10,
  /// <summary>
  /// Specifies the theme colors for document themes.
  /// </summary>
  ThemeColorHyperlinkFollowed = 11,
  /// <summary>
  /// Specifies the theme colors for document themes.
  /// </summary>
  ThemeColorBackground1 = 12,
  /// <summary>
  /// Specifies the theme colors for document themes.
  /// </summary>
  ThemeColorText1 = 13,
  /// <summary>
  /// Specifies the theme colors for document themes.
  /// </summary>
  ThemeColorBackground2 = 14,
  /// <summary>
  /// Specifies the theme colors for document themes.
  /// </summary>
  ThemeColorText2 = 15,
  /// <summary>
  /// No color.
  /// </summary>
  NotThemeColor = -1
}
