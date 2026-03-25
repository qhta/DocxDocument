namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the intensity of light used on a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingsoftness?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoPresetLightingSoftness
{
  /// <summary>
  /// Specifies the intensity of light used on a shape.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Dim light.
  /// </summary>
  Dim = 1,
  /// <summary>
  /// Normal light.
  /// </summary>
  Normal = 2,
  /// <summary>
  /// Bright light.
  /// </summary>
  Bright = 3
}
