namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the texture type for the selected fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturetype?view=office-pia` for Office interop details.
/// </remarks>
public enum TextureType
{
  /// <summary>
  /// Specifies the texture type for the selected fill.
  /// </summary>
  /// <summary>
  /// Preset texture type.
  /// </summary>
  Preset = 1,
  /// <summary>
  /// User-defined texture type.
  /// </summary>
  UserDefined = 2
}
