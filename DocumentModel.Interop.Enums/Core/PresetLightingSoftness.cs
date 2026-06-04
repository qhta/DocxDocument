namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the intensity of light used on a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingsoftness?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetLightingSoftness")]
public enum PresetLightingSoftness
{
  /// <summary>
  /// Specifies the intensity of light used on a shape.
  /// </summary>
  [InteropEnumValue("msoPresetLightingSoftnessMixed")]
  Mixed = -2,
  /// <summary>
  /// Dim light.
  /// </summary>
  [InteropEnumValue("msoLightingDim")]
  Dim = 1,
  /// <summary>
  /// Normal light.
  /// </summary>
  [InteropEnumValue("msoLightingNormal")]
  Normal = 2,
  /// <summary>
  /// Bright light.
  /// </summary>
  [InteropEnumValue("msoLightingBright")]
  Bright = 3
}
