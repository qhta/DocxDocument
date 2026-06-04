namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation for text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextOrientation))]
public enum TextOrientation
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationMixed))]
  Mixed = -2,
  /// <summary>
  /// Horizontal.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal))]
  Horizontal = 1,
  /// <summary>
  /// Upward.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationUpward))]
  Upward = 2,
  /// <summary>
  /// Downward.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationDownward))]
  Downward = 3,
  /// <summary>
  /// Vertical as required for Far East language support.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationVerticalFarEast))]
  VerticalFarEast = 4,
  /// <summary>
  /// Vertical.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationVertical))]
  Vertical = 5,
  /// <summary>
  /// Horizontal and rotated as required for Far East language support.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontalRotatedFarEast))]
  HorizontalRotatedFarEast = 6
}
