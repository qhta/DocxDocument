namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlTickLabelOrientation")]
public enum TickLabelOrientation
{
  /// <summary>
  /// Text runs up.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelOrientationUpward")]
  Upward = -4171,
  /// <summary>
  /// Text runs down.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelOrientationDownward")]
  Downward = -4170,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelOrientationVertical")]
  Vertical = -4166,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelOrientationHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// Text orientation set by Word.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelOrientationAutomatic")]
  Automatic = -4105
}
