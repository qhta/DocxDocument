namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlTickLabelOrientation")]
public enum TickLabelOrientation
{
  /// <summary>
  /// Text runs up.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationUpward")]
  Upward = -4171,
  /// <summary>
  /// Text runs down.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationDownward")]
  Downward = -4170,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationVertical")]
  Vertical = -4166,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// Text orientation set by Word.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationAutomatic")]
  Automatic = -4105
}

