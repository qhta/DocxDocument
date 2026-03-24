namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color to apply.
/// </summary>
public enum WdColorIndex
{
  /// <summary>
  /// Automatic color. Default; usually black.
  /// </summary>
  Auto = unchecked((int)0),
  /// <summary>
  /// Removes highlighting that has been applied.
  /// </summary>
  NoHighlight = unchecked((int)0),
  /// <summary>
  /// Black color.
  /// </summary>
  Black = unchecked((int)1),
  /// <summary>
  /// Blue color.
  /// </summary>
  Blue = unchecked((int)2),
  /// <summary>
  /// Turquoise color.
  /// </summary>
  Turquoise = unchecked((int)3),
  /// <summary>
  /// Bright green color.
  /// </summary>
  BrightGreen = unchecked((int)4),
  /// <summary>
  /// Pink color.
  /// </summary>
  Pink = unchecked((int)5),
  /// <summary>
  /// Red color.
  /// </summary>
  Red = unchecked((int)6),
  /// <summary>
  /// Yellow color.
  /// </summary>
  Yellow = unchecked((int)7),
  /// <summary>
  /// White color. [System.Runtime.InteropServices.Guid("B1F5A6AB-437D-319F-8B38-0E087D112FEA")] public enum
  /// WdColorIndex ﾉ Expand table
  /// </summary>
  White = unchecked((int)8),
  /// <summary>
  /// Dark blue color.
  /// </summary>
  DarkBlue = unchecked((int)9),
  /// <summary>
  /// Teal color.
  /// </summary>
  Teal = unchecked((int)10),
  /// <summary>
  /// Green color.
  /// </summary>
  Green = unchecked((int)11),
  /// <summary>
  /// Violet color.
  /// </summary>
  Violet = unchecked((int)12),
  /// <summary>
  /// Dark red color.
  /// </summary>
  DarkRed = unchecked((int)13),
  /// <summary>
  /// Dark yellow color.
  /// </summary>
  DarkYellow = unchecked((int)14),
  /// <summary>
  /// Shade 50 of gray color.
  /// </summary>
  Gray50 = unchecked((int)15),
  /// <summary>
  /// Shade 25 of gray color.
  /// </summary>
  Gray25 = unchecked((int)16),
  /// <summary>
  /// Specifies the color to apply.
  /// </summary>
  ByAuthor = unchecked((int)-1)
}
