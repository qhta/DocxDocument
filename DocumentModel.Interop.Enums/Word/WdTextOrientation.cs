namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text direction in a range or selection.
/// </summary>
public enum WdTextOrientation
{
  /// <summary>
  /// Text flows horizontally. default.
  /// </summary>
  wdTextOrientationHorizontal = unchecked((int)0),
  /// <summary>
  /// Text flows vertically and reads downward from the top.
  /// </summary>
  wdTextOrientationVerticalFarEast = unchecked((int)1),
  /// <summary>
  /// Text flows upward on a slope.
  /// </summary>
  wdTextOrientationUpward = unchecked((int)2),
  /// <summary>
  /// Text flows downward on a slope.
  /// </summary>
  wdTextOrientationDownward = unchecked((int)3),
  /// <summary>
  /// Text flows horizontally but from right to left to accommodate Far East languages.
  /// </summary>
  wdTextOrientationHorizontalRotatedFarEast = unchecked((int)4),
  /// <summary>
  /// Text flows vertically and reads downward from the top, left to right.
  /// </summary>
  wdTextOrientationVertical = unchecked((int)5)
}
