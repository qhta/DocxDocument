namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the intensity of light used on a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingsoftness?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetLightingSoftness")]
public enum PresetLightingSoftness
{
  /// <summary>
  /// Specifies the intensity of light used on a shape.
  /// </summary>
  [OfficeInteropEnumValue("msoPresetLightingSoftnessMixed")]
  Mixed = -2,
  /// <summary>
  /// Dim light.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingDim")]
  Dim = 1,
  /// <summary>
  /// Normal light.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingNormal")]
  Normal = 2,
  /// <summary>
  /// Bright light.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingBright")]
  Bright = 3
}
