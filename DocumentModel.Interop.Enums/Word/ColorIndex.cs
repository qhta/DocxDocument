namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolorindex?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdColorIndex")]
public enum ColorIndex
{
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  [WordInteropEnumValue("wdAuto")]
  Auto = 0,
  /// <summary>
  /// Removes highlighting that has been applied.
  /// </summary>
  [WordInteropEnumValue("wdNoHighlight")]
  NoHighlight = 0,
  /// <summary>
  /// Black color.
  /// </summary>
  [WordInteropEnumValue("wdBlack")]
  Black = 1,
  /// <summary>
  /// Blue color.
  /// </summary>
  [WordInteropEnumValue("wdBlue")]
  Blue = 2,
  /// <summary>
  /// Turquoise color.
  /// </summary>
  [WordInteropEnumValue("wdTurquoise")]
  Turquoise = 3,
  /// <summary>
  /// Bright green color.
  /// </summary>
  [WordInteropEnumValue("wdBrightGreen")]
  BrightGreen = 4,
  /// <summary>
  /// Pink color.
  /// </summary>
  [WordInteropEnumValue("wdPink")]
  Pink = 5,
  /// <summary>
  /// Red color.
  /// </summary>
  [WordInteropEnumValue("wdRed")]
  Red = 6,
  /// <summary>
  /// Yellow color.
  /// </summary>
  [WordInteropEnumValue("wdYellow")]
  Yellow = 7,
  /// <summary>
  /// White color.
  /// </summary>
  [WordInteropEnumValue("wdWhite")]
  White = 8,
  /// <summary>
  /// Dark blue color.
  /// </summary>
  [WordInteropEnumValue("wdDarkBlue")]
  DarkBlue = 9,
  /// <summary>
  /// Teal color.
  /// </summary>
  [WordInteropEnumValue("wdTeal")]
  Teal = 10,
  /// <summary>
  /// Green color.
  /// </summary>
  [WordInteropEnumValue("wdGreen")]
  Green = 11,
  /// <summary>
  /// Violet color.
  /// </summary>
  [WordInteropEnumValue("wdViolet")]
  Violet = 12,
  /// <summary>
  /// Dark red color.
  /// </summary>
  [WordInteropEnumValue("wdDarkRed")]
  DarkRed = 13,
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  [WordInteropEnumValue("wdDarkYellow")]
  DarkYellow = 14,
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdGray50")]
  Gray50 = 15,
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  [WordInteropEnumValue("wdGray25")]
  Gray25 = 16,
  /// <summary>
  /// Color defined by document author.
  /// </summary>
  [WordInteropEnumValue("wdByAuthor")]
  ByAuthor = -1
}
