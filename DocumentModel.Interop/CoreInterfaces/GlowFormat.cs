
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a glow effect around an Office graphic.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat?view=office-pia
/// </remarks>
public partial interface GlowFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Radius` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat.radius?view=office-pia
  /// </remarks>
  public float Radius { get; set; }
  /// <summary>
  /// Gets the `Color` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat.color?view=office-pia
  /// </remarks>
  public ColorFormat Color { get; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
}
