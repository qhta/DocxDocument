namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolorindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdColorIndex")]
public enum ColorIndex
{
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  [InteropEnumValue("wdAuto")]
  Auto = 0,
  /// <summary>
  /// Removes highlighting that has been applied.
  /// </summary>
  [InteropEnumValue("wdNoHighlight")]
  NoHighlight = 0,
  /// <summary>
  /// Black color.
  /// </summary>
  [InteropEnumValue("wdBlack")]
  Black = 1,
  /// <summary>
  /// Blue color.
  /// </summary>
  [InteropEnumValue("wdBlue")]
  Blue = 2,
  /// <summary>
  /// Turquoise color.
  /// </summary>
  [InteropEnumValue("wdTurquoise")]
  Turquoise = 3,
  /// <summary>
  /// Bright green color.
  /// </summary>
  [InteropEnumValue("wdBrightGreen")]
  BrightGreen = 4,
  /// <summary>
  /// Pink color.
  /// </summary>
  [InteropEnumValue("wdPink")]
  Pink = 5,
  /// <summary>
  /// Red color.
  /// </summary>
  [InteropEnumValue("wdRed")]
  Red = 6,
  /// <summary>
  /// Yellow color.
  /// </summary>
  [InteropEnumValue("wdYellow")]
  Yellow = 7,
  /// <summary>
  /// White color.
  /// </summary>
  [InteropEnumValue("wdWhite")]
  White = 8,
  /// <summary>
  /// Dark blue color.
  /// </summary>
  [InteropEnumValue("wdDarkBlue")]
  DarkBlue = 9,
  /// <summary>
  /// Teal color.
  /// </summary>
  [InteropEnumValue("wdTeal")]
  Teal = 10,
  /// <summary>
  /// Green color.
  /// </summary>
  [InteropEnumValue("wdGreen")]
  Green = 11,
  /// <summary>
  /// Violet color.
  /// </summary>
  [InteropEnumValue("wdViolet")]
  Violet = 12,
  /// <summary>
  /// Dark red color.
  /// </summary>
  [InteropEnumValue("wdDarkRed")]
  DarkRed = 13,
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  [InteropEnumValue("wdDarkYellow")]
  DarkYellow = 14,
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  [InteropEnumValue("wdGray50")]
  Gray50 = 15,
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  [InteropEnumValue("wdGray25")]
  Gray25 = 16,
  /// <summary>
  /// Color defined by document author.
  /// </summary>
  [InteropEnumValue("wdByAuthor")]
  ByAuthor = -1
}
