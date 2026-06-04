namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of gradient used in a shape's fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msogradientcolortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoGradientColorType")]
public enum GradientColorType
{
  /// <summary>
  /// Mixed gradient.
  /// </summary>
  [InteropEnumValue("msoGradientColorMixed")]
  ColorMixed = -2,
  /// <summary>
  /// One-color gradient.
  /// </summary>
  [InteropEnumValue("msoGradientOneColor")]
  OneColor = 1,
  /// <summary>
  /// Two-color gradient.
  /// </summary>
  [InteropEnumValue("msoGradientTwoColors")]
  TwoColors = 2,
  /// <summary>
  /// Gradient colors set according to a built-in gradient of the set defined by the msoPresetGradientType constant.
  /// </summary>
  [InteropEnumValue("msoGradientPresetColors")]
  PresetColors = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoGradientMultiColor")]
  MultiColor = 4
}
