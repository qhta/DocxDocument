namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text direction in a range or selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTextOrientation")]
public enum TextOrientation
{
  /// <summary>
  /// Text flows horizontally. default.
  /// </summary>
  [InteropEnumValue("wdTextOrientationHorizontal")]
  Horizontal = 0,
  /// <summary>
  /// Text flows vertically and reads downward from the top.
  /// </summary>
  [InteropEnumValue("wdTextOrientationVerticalFarEast")]
  VerticalFarEast = 1,
  /// <summary>
  /// Text flows upward on a slope.
  /// </summary>
  [InteropEnumValue("wdTextOrientationUpward")]
  Upward = 2,
  /// <summary>
  /// Text flows downward on a slope.
  /// </summary>
  [InteropEnumValue("wdTextOrientationDownward")]
  Downward = 3,
  /// <summary>
  /// Text flows horizontally but from right to left to accommodate Far East languages.
  /// </summary>
  [InteropEnumValue("wdTextOrientationHorizontalRotatedFarEast")]
  HorizontalRotatedFarEast = 4,
  /// <summary>
  /// Text flows vertically and reads downward from the top, left to right.
  /// </summary>
  [InteropEnumValue("wdTextOrientationVertical")]
  Vertical = 5
}
