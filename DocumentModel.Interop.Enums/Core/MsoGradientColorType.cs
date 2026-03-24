namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of gradient used in a shape's fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msogradientcolortype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoGradientColorType
{
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  ColorMixed = -2,
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  OneColor = 1,
  /// <summary>
  /// Two-color gradient. msoGradientPresetColors3 Gradient colors set according to a built-in gradient of the set
  /// defined by the msoPresetGradientType constant. msoGradientMultiColor4
  /// </summary>
  TwoColors = 2,
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  PresetColors = 3,
  /// <summary>
  /// Specifies the type of gradient used in a shape's fill.
  /// </summary>
  MultiColor = 4
}
