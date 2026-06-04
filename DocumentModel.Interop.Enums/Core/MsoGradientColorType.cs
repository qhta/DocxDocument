namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of gradient used in a shape's fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msogradientcolortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoGradientColorType")]
public enum GradientColorType
{
  /// <summary>
  /// Mixed gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientColorMixed")]
  ColorMixed = -2,
  /// <summary>
  /// One-color gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientOneColor")]
  OneColor = 1,
  /// <summary>
  /// Two-color gradient.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientTwoColors")]
  TwoColors = 2,
  /// <summary>
  /// Gradient colors set according to a built-in gradient of the set defined by the msoPresetGradientType constant.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientPresetColors")]
  PresetColors = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoGradientMultiColor")]
  MultiColor = 4
}
