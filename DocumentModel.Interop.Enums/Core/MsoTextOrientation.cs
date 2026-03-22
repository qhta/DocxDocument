namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation for text.
/// </summary>
public enum MsoTextOrientation
{
  /// <summary>
  /// Specifies orientation for text.
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
