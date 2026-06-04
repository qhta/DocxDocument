namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the intensity of light used on a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingsoftness?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetLightingSoftness))]
public enum PresetLightingSoftness
{
  /// <summary>
  /// Specifies the intensity of light used on a shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingSoftness.msoPresetLightingSoftnessMixed))]
  Mixed = -2,
  /// <summary>
  /// Dim light.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingSoftness.msoLightingDim))]
  Dim = 1,
  /// <summary>
  /// Normal light.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingSoftness.msoLightingNormal))]
  Normal = 2,
  /// <summary>
  /// Bright light.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingSoftness.msoLightingBright))]
  Bright = 3
}
