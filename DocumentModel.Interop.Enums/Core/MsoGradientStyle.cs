namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a gradient fill.
/// </summary>
public enum MsoGradientStyle
{
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  Horizontal = 1,
  /// <summary>
  /// Gradient running vertically down the shape. msoGradientDiagonalUp3 Diagonal gradient moving from a bottom
  /// corner up to the opposite corner. msoGradientDiagonalDown4 Diagonal gradient moving from a top corner down to
  /// the opposite corner. msoGradientFromCorner5 Gradient running from a corner to the other three corners.
  /// </summary>
  Vertical = 2,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  DiagonalUp = 3,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  DiagonalDown = 4,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  FromCorner = 5,
  /// <summary>
  /// Gradient running from the title outward. msoGradientFromCenter7 Gradient running from the center out to the
  /// corners.
  /// </summary>
  FromTitle = 6,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  FromCenter = 7
}
