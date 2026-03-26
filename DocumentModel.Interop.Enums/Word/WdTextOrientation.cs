namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text direction in a range or selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum TextOrientation
{
  /// <summary>
  /// Text flows horizontally. default.
  /// </summary>
  Horizontal = 0,
  /// <summary>
  /// Text flows vertically and reads downward from the top.
  /// </summary>
  VerticalFarEast = 1,
  /// <summary>
  /// Text flows upward on a slope.
  /// </summary>
  Upward = 2,
  /// <summary>
  /// Text flows downward on a slope.
  /// </summary>
  Downward = 3,
  /// <summary>
  /// Text flows horizontally but from right to left to accommodate Far East languages.
  /// </summary>
  HorizontalRotatedFarEast = 4,
  /// <summary>
  /// Text flows vertically and reads downward from the top, left to right.
  /// </summary>
  Vertical = 5
}
