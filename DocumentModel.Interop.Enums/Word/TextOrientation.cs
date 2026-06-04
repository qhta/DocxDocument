namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text direction in a range or selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTextOrientation))]
public enum TextOrientation
{
  /// <summary>
  /// Text flows horizontally. default.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationHorizontal))]
  Horizontal = 0,
  /// <summary>
  /// Text flows vertically and reads downward from the top.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationVerticalFarEast))]
  VerticalFarEast = 1,
  /// <summary>
  /// Text flows upward on a slope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationUpward))]
  Upward = 2,
  /// <summary>
  /// Text flows downward on a slope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationDownward))]
  Downward = 3,
  /// <summary>
  /// Text flows horizontally but from right to left to accommodate Far East languages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationHorizontalRotatedFarEast))]
  HorizontalRotatedFarEast = 4,
  /// <summary>
  /// Text flows vertically and reads downward from the top, left to right.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationVertical))]
  Vertical = 5
}
