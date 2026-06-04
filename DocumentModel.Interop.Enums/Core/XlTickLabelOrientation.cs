
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the text
/// orientation for tick-mark labels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlticklabelorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlTickLabelOrientation))]
public enum TickLabelOrientation
{
  /// <summary>
  /// Text orientation set by Excel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickLabelOrientation.xlTickLabelOrientationAutomatic))]
  Automatic = -4105,
  /// <summary>
  /// Text runs down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickLabelOrientation.xlTickLabelOrientationDownward))]
  Downward = -4170,
  /// <summary>
  /// Characters run horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickLabelOrientation.xlTickLabelOrientationHorizontal))]
  Horizontal = -4128,
  /// <summary>
  /// Text runs up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickLabelOrientation.xlTickLabelOrientationUpward))]
  Upward = -4171,
  /// <summary>
  /// Characters run vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickLabelOrientation.xlTickLabelOrientationVertical))]
  Vertical = -4166
}
