namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation for text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoTextOrientation
{
  /// <summary>
  /// Not supported.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Horizontal.
  /// </summary>
  Horizontal = 1,
  /// <summary>
  /// Upward.
  /// </summary>
  Upward = 2,
  /// <summary>
  /// Downward.
  /// </summary>
  Downward = 3,
  /// <summary>
  /// Vertical as required for Far East language support.
  /// </summary>
  VerticalFarEast = 4,
  /// <summary>
  /// Vertical.
  /// </summary>
  Vertical = 5,
  /// <summary>
  /// Horizontal and rotated as required for Far East language support.
  /// </summary>
  HorizontalRotatedFarEast = 6
}
