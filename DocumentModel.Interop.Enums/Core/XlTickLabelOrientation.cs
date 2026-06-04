
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the text
/// orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlTickLabelOrientation")]
public enum TickLabelOrientation
{
  /// <summary>
  /// Text orientation set by Excel.
  /// </summary>
  [OfficeInteropEnumValue("xlTickLabelOrientationAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// Text runs down.
  /// </summary>
  [OfficeInteropEnumValue("xlTickLabelOrientationDownward")]
  Downward = -4170,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  [OfficeInteropEnumValue("xlTickLabelOrientationHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// Text runs up.
  /// </summary>
  [OfficeInteropEnumValue("xlTickLabelOrientationUpward")]
  Upward = -4171,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  [OfficeInteropEnumValue("xlTickLabelOrientationVertical")]
  Vertical = -4166
}
