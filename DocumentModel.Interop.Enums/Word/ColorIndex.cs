namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolorindex?view=office-pia` for Office interop details.
/// </remarks>
public enum ColorIndex
{
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Removes highlighting that has been applied.
  /// </summary>
  NoHighlight = 0,
  /// <summary>
  /// Black color.
  /// </summary>
  Black = 1,
  /// <summary>
  /// Blue color.
  /// </summary>
  Blue = 2,
  /// <summary>
  /// Turquoise color.
  /// </summary>
  Turquoise = 3,
  /// <summary>
  /// Bright green color.
  /// </summary>
  BrightGreen = 4,
  /// <summary>
  /// Pink color.
  /// </summary>
  Pink = 5,
  /// <summary>
  /// Red color.
  /// </summary>
  Red = 6,
  /// <summary>
  /// Yellow color.
  /// </summary>
  Yellow = 7,
  /// <summary>
  /// White color.
  /// </summary>
  White = 8,
  /// <summary>
  /// Dark blue color.
  /// </summary>
  DarkBlue = 9,
  /// <summary>
  /// Teal color.
  /// </summary>
  Teal = 10,
  /// <summary>
  /// Green color.
  /// </summary>
  Green = 11,
  /// <summary>
  /// Violet color.
  /// </summary>
  Violet = 12,
  /// <summary>
  /// Dark red color.
  /// </summary>
  DarkRed = 13,
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  DarkYellow = 14,
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  Gray50 = 15,
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  Gray25 = 16,
  /// <summary>
  /// Color defined by document author.
  /// </summary>
  ByAuthor = -1
}
