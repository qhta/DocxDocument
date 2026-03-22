namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a gradient fill.
/// </summary>
public enum MsoGradientStyle
{
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  msoGradientMixed = -2,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  msoGradientHorizontal = 1,
  /// <summary>
  /// Gradient running vertically down the shape. msoGradientDiagonalUp3 Diagonal gradient moving from a bottom
  /// corner up to the opposite corner. msoGradientDiagonalDown4 Diagonal gradient moving from a top corner down to
  /// the opposite corner. msoGradientFromCorner5 Gradient running from a corner to the other three corners.
  /// </summary>
  msoGradientVertical = 2,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  msoGradientDiagonalUp = 3,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  msoGradientDiagonalDown = 4,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  msoGradientFromCorner = 5,
  /// <summary>
  /// Gradient running from the title outward. msoGradientFromCenter7 Gradient running from the center out to the
  /// corners.
  /// </summary>
  msoGradientFromTitle = 6,
  /// <summary>
  /// Specifies the style for a gradient fill.
  /// </summary>
  msoGradientFromCenter = 7
}
