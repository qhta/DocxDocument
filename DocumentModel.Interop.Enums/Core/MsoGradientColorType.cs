namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of gradient used in a shape's fill.
/// </summary>
public enum MsoGradientColorType
{
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  msoGradientColorMixed = -2,
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  msoGradientOneColor = 1,
  /// <summary>
  /// Two-color gradient. msoGradientPresetColors3 Gradient colors set according to a built-in gradient of the set
  /// defined by the msoPresetGradientType constant. msoGradientMultiColor4
  /// </summary>
  msoGradientTwoColors = 2,
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  msoGradientPresetColors = 3,
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  msoGradientMultiColor = 4
}
