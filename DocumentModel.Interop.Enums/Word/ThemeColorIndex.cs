namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the theme colors for document themes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdthemecolorindex?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdThemeColorIndex))]
public enum ThemeColorIndex
{
  /// <summary>
  /// Dark main color 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorMainDark1))]
  ThemeColorMainDark1 = 0,
  /// <summary>
  /// Light main color 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorMainLight1))]
  ThemeColorMainLight1 = 1,
  /// <summary>
  /// Dark main color 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorMainDark2))]
  ThemeColorMainDark2 = 2,
  /// <summary>
  /// Light main color 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorMainLight2))]
  ThemeColorMainLight2 = 3,
  /// <summary>
  /// Accent color 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorAccent1))]
  ThemeColorAccent1 = 4,
  /// <summary>
  /// Accent color 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorAccent2))]
  ThemeColorAccent2 = 5,
  /// <summary>
  /// Accent color 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorAccent3))]
  ThemeColorAccent3 = 6,
  /// <summary>
  /// Accent color 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorAccent4))]
  ThemeColorAccent4 = 7,
  /// <summary>
  /// Accent color 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorAccent5))]
  ThemeColorAccent5 = 8,
  /// <summary>
  /// Accent color 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorAccent6))]
  ThemeColorAccent6 = 9,
  /// <summary>
  /// Hyperlink color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorHyperlink))]
  ThemeColorHyperlink = 10,
  /// <summary>
  /// Followed hyperlink color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorHyperlinkFollowed))]
  ThemeColorHyperlinkFollowed = 11,
  /// <summary>
  /// Background color 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorBackground1))]
  ThemeColorBackground1 = 12,
  /// <summary>
  /// Text color 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorText1))]
  ThemeColorText1 = 13,
  /// <summary>
  /// Background color 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorBackground2))]
  ThemeColorBackground2 = 14,
  /// <summary>
  /// Text color 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdThemeColorText2))]
  ThemeColorText2 = 15,
  /// <summary>
  /// No color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdThemeColorIndex.wdNotThemeColor))]
  NotThemeColor = -1
}
