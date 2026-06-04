namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a gradient fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msogradientstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoGradientStyle")]
public enum GradientStyle
{
  /// <summary>
  /// Gradient is mixed.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientMixed")]
  Mixed = -2,
  /// <summary>
  /// Gradient running horizontally across the shape.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientHorizontal")]
  Horizontal = 1,
  /// <summary>
  /// Gradient running vertically down the shape.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientVertical")]
  Vertical = 2,
  /// <summary>
  /// Diagonal gradient moving from a bottom corner up to the opposite corner.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientDiagonalUp")]
  DiagonalUp = 3,
  /// <summary>
  /// Diagonal gradient moving from a top corner down to the opposite corner.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientDiagonalDown")]
  DiagonalDown = 4,
  /// <summary>
  /// Gradient running from a corner to the other three corners.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientFromCorner")]
  FromCorner = 5,
  /// <summary>
  /// Gradient running from the title outward.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientFromTitle")]
  FromTitle = 6,
  /// <summary>
  /// Gradient running from the center out to the corners.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientFromCenter")]
  FromCenter = 7
}
