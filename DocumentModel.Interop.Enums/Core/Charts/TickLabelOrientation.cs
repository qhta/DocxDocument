
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the text
/// orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlTickLabelOrientation")]
public enum TickLabelOrientation
{
  /// <summary>
  /// Text orientation set by Excel.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// Text runs down.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationDownward")]
  Downward = -4170,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// Text runs up.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationUpward")]
  Upward = -4171,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  [InteropEnumValue("xlTickLabelOrientationVertical")]
  Vertical = -4166
}
