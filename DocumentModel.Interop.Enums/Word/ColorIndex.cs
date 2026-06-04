namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolorindex?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdColorIndex))]
public enum ColorIndex
{
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdAuto))]
  Auto = 0,
  /// <summary>
  /// Removes highlighting that has been applied.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdNoHighlight))]
  NoHighlight = 0,
  /// <summary>
  /// Black color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdBlack))]
  Black = 1,
  /// <summary>
  /// Blue color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdBlue))]
  Blue = 2,
  /// <summary>
  /// Turquoise color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdTurquoise))]
  Turquoise = 3,
  /// <summary>
  /// Bright green color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdBrightGreen))]
  BrightGreen = 4,
  /// <summary>
  /// Pink color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdPink))]
  Pink = 5,
  /// <summary>
  /// Red color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdRed))]
  Red = 6,
  /// <summary>
  /// Yellow color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdYellow))]
  Yellow = 7,
  /// <summary>
  /// White color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdWhite))]
  White = 8,
  /// <summary>
  /// Dark blue color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdDarkBlue))]
  DarkBlue = 9,
  /// <summary>
  /// Teal color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdTeal))]
  Teal = 10,
  /// <summary>
  /// Green color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdGreen))]
  Green = 11,
  /// <summary>
  /// Violet color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdViolet))]
  Violet = 12,
  /// <summary>
  /// Dark red color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed))]
  DarkRed = 13,
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdDarkYellow))]
  DarkYellow = 14,
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdGray50))]
  Gray50 = 15,
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdGray25))]
  Gray25 = 16,
  /// <summary>
  /// Color defined by document author.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdColorIndex.wdByAuthor))]
  ByAuthor = -1
}
