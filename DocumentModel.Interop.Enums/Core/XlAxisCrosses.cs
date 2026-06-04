
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the point
/// on the specified axis where the other axis crosses.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxiscrosses?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlAxisCrosses")]
public enum AxisCrosses
{
  /// <summary>
  /// Microsoft Excel sets the axis crossing point.
  /// </summary>
  [OfficeInteropEnumValue("xlAxisCrossesAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// The CrossesAt property specifies the axis crossing point.
  /// </summary>
  [OfficeInteropEnumValue("xlAxisCrossesCustom")]
  Custom = -4114,
  /// <summary>
  /// The axis crosses at the maximum value.
  /// </summary>
  [OfficeInteropEnumValue("xlAxisCrossesMaximum")]
  Maximum = 2,
  /// <summary>
  /// The axis crosses at the minimum value.
  /// </summary>
  [OfficeInteropEnumValue("xlAxisCrossesMinimum")]
  Minimum = 4
}
