namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a gradient fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msogradientstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoGradientStyle")]
public enum GradientStyle
{
  /// <summary>
  /// Gradient is mixed.
  /// </summary>
  [InteropEnumValue("msoGradientMixed")]
  Mixed = -2,
  /// <summary>
  /// Gradient running horizontally across the shape.
  /// </summary>
  [InteropEnumValue("msoGradientHorizontal")]
  Horizontal = 1,
  /// <summary>
  /// Gradient running vertically down the shape.
  /// </summary>
  [InteropEnumValue("msoGradientVertical")]
  Vertical = 2,
  /// <summary>
  /// Diagonal gradient moving from a bottom corner up to the opposite corner.
  /// </summary>
  [InteropEnumValue("msoGradientDiagonalUp")]
  DiagonalUp = 3,
  /// <summary>
  /// Diagonal gradient moving from a top corner down to the opposite corner.
  /// </summary>
  [InteropEnumValue("msoGradientDiagonalDown")]
  DiagonalDown = 4,
  /// <summary>
  /// Gradient running from a corner to the other three corners.
  /// </summary>
  [InteropEnumValue("msoGradientFromCorner")]
  FromCorner = 5,
  /// <summary>
  /// Gradient running from the title outward.
  /// </summary>
  [InteropEnumValue("msoGradientFromTitle")]
  FromTitle = 6,
  /// <summary>
  /// Gradient running from the center out to the corners.
  /// </summary>
  [InteropEnumValue("msoGradientFromCenter")]
  FromCenter = 7
}
