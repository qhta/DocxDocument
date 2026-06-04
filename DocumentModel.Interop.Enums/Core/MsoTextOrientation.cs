namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation for text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTextOrientation")]
public enum TextOrientation
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationMixed")]
  Mixed = -2,
  /// <summary>
  /// Horizontal.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationHorizontal")]
  Horizontal = 1,
  /// <summary>
  /// Upward.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationUpward")]
  Upward = 2,
  /// <summary>
  /// Downward.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationDownward")]
  Downward = 3,
  /// <summary>
  /// Vertical as required for Far East language support.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationVerticalFarEast")]
  VerticalFarEast = 4,
  /// <summary>
  /// Vertical.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationVertical")]
  Vertical = 5,
  /// <summary>
  /// Horizontal and rotated as required for Far East language support.
  /// </summary>
  [OfficeInteropEnumValue("msoTextOrientationHorizontalRotatedFarEast")]
  HorizontalRotatedFarEast = 6
}
