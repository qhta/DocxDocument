namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the texture type for the selected fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextureType))]
public enum TextureType
{
  /// <summary>
  /// Specifies the texture type for the selected fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureType.msoTextureTypeMixed))]
  Mixed = -2,
  /// <summary>
  /// Preset texture type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureType.msoTexturePreset))]
  Preset = 1,
  /// <summary>
  /// User-defined texture type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureType.msoTextureUserDefined))]
  UserDefined = 2
}
