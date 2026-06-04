namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the point on the specified axis where the other axis crosses.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlaxiscrosses?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlAxisCrosses")]
public enum AxisCrosses
{
  /// <summary>
  /// The axis crosses at the maximum value.
  /// </summary>
  [WordInteropEnumValue("xlAxisCrossesMaximum")]
  Maximum = 2,
  /// <summary>
  /// The axis crosses at the minimum value.
  /// </summary>
  [WordInteropEnumValue("xlAxisCrossesMinimum")]
  Minimum = 4,
  /// <summary>
  /// The CrossesAt property specifies the axis crossing point.
  /// </summary>
  [WordInteropEnumValue("xlAxisCrossesCustom")]
  Custom = -4114,
  /// <summary>
  /// Microsoft Word sets the axis crossing point.
  /// </summary>
  [WordInteropEnumValue("xlAxisCrossesAutomatic")]
  Automatic = -4105
}
