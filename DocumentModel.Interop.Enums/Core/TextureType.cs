namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the texture type for the selected fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextureType")]
public enum TextureType
{
  /// <summary>
  /// Specifies the texture type for the selected fill.
  /// </summary>
  [InteropEnumValue("msoTextureTypeMixed")]
  Mixed = -2,
  /// <summary>
  /// Preset texture type.
  /// </summary>
  [InteropEnumValue("msoTexturePreset")]
  Preset = 1,
  /// <summary>
  /// User-defined texture type.
  /// </summary>
  [InteropEnumValue("msoTextureUserDefined")]
  UserDefined = 2
}
