namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the point on the specified axis where the other axis crosses.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxiscrosses?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlAxisCrosses))]
public enum AxisCrosses
{
  /// <summary>
  /// The axis crosses at the maximum value.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlAxisCrosses.xlAxisCrossesMaximum))]
  Maximum = 2,
  /// <summary>
  /// The axis crosses at the minimum value.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlAxisCrosses.xlAxisCrossesMinimum))]
  Minimum = 4,
  /// <summary>
  /// The CrossesAt property specifies the axis crossing point.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlAxisCrosses.xlAxisCrossesCustom))]
  Custom = -4114,
  /// <summary>
  /// Microsoft Word sets the axis crossing point.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlAxisCrosses.xlAxisCrossesAutomatic))]
  Automatic = -4105
}
