namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation for text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextOrientation")]
public enum TextOrientation
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoTextOrientationMixed")]
  Mixed = -2,
  /// <summary>
  /// Horizontal.
  /// </summary>
  [InteropEnumValue("msoTextOrientationHorizontal")]
  Horizontal = 1,
  /// <summary>
  /// Upward.
  /// </summary>
  [InteropEnumValue("msoTextOrientationUpward")]
  Upward = 2,
  /// <summary>
  /// Downward.
  /// </summary>
  [InteropEnumValue("msoTextOrientationDownward")]
  Downward = 3,
  /// <summary>
  /// Vertical as required for Far East language support.
  /// </summary>
  [InteropEnumValue("msoTextOrientationVerticalFarEast")]
  VerticalFarEast = 4,
  /// <summary>
  /// Vertical.
  /// </summary>
  [InteropEnumValue("msoTextOrientationVertical")]
  Vertical = 5,
  /// <summary>
  /// Horizontal and rotated as required for Far East language support.
  /// </summary>
  [InteropEnumValue("msoTextOrientationHorizontalRotatedFarEast")]
  HorizontalRotatedFarEast = 6
}
