namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlTickLabelOrientation))]
public enum TickLabelOrientation
{
  /// <summary>
  /// Text runs up.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelOrientation.xlTickLabelOrientationUpward))]
  Upward = -4171,
  /// <summary>
  /// Text runs down.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelOrientation.xlTickLabelOrientationDownward))]
  Downward = -4170,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelOrientation.xlTickLabelOrientationVertical))]
  Vertical = -4166,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelOrientation.xlTickLabelOrientationHorizontal))]
  Horizontal = -4128,
  /// <summary>
  /// Text orientation set by Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelOrientation.xlTickLabelOrientationAutomatic))]
  Automatic = -4105
}
