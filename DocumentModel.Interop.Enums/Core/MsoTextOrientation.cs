namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation for text.
/// </summary>
public enum MsoTextOrientation
{
  /// <summary>
  /// Specifies orientation for text.
  /// </summary>
  msoTextOrientationMixed = -2,
  /// <summary>
  /// Horizontal.
  /// </summary>
  msoTextOrientationHorizontal = 1,
  /// <summary>
  /// Upward.
  /// </summary>
  msoTextOrientationUpward = 2,
  /// <summary>
  /// Downward.
  /// </summary>
  msoTextOrientationDownward = 3,
  /// <summary>
  /// Vertical as required for Far East language support.
  /// </summary>
  msoTextOrientationVerticalFarEast = 4,
  /// <summary>
  /// Vertical.
  /// </summary>
  msoTextOrientationVertical = 5,
  /// <summary>
  /// Horizontal and rotated as required for Far East language support.
  /// </summary>
  msoTextOrientationHorizontalRotatedFarEast = 6
}
