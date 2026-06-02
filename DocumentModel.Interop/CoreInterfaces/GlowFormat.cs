
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a glow effect around an Office graphic.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat?view=office-pia"/>
public partial interface IGlowFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Radius` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat.radius?view=office-pia"/>
  public float Radius { get; set; }
  /// <summary>
  /// Gets the `Color` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat.color?view=office-pia"/>
  public ColorFormat Color { get; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.glowformat.transparency?view=office-pia"/>
  public float Transparency { get; set; }
}

