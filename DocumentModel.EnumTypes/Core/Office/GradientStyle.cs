namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the style for a gradient fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msogradientstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum GradientStyle
{
  /// <summary>
  /// Gradient is mixed.
  /// </summary>
  /// <summary>
  /// Gradient running horizontally across the shape.
  /// </summary>
  Horizontal = 1,
  /// <summary>
  /// Gradient running vertically down the shape.
  /// </summary>
  Vertical = 2,
  /// <summary>
  /// Diagonal gradient moving from a bottom corner up to the opposite corner.
  /// </summary>
  DiagonalUp = 3,
  /// <summary>
  /// Diagonal gradient moving from a top corner down to the opposite corner.
  /// </summary>
  DiagonalDown = 4,
  /// <summary>
  /// Gradient running from a corner to the other three corners.
  /// </summary>
  FromCorner = 5,
  /// <summary>
  /// Gradient running from the title outward.
  /// </summary>
  FromTitle = 6,
  /// <summary>
  /// Gradient running from the center out to the corners.
  /// </summary>
  FromCenter = 7
}
