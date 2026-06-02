
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents one gradient stop.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop?view=office-pia"/>
public partial interface IGradientStop: InteropObject
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.color?view=office-pia"/>
  public ColorFormat Color { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.position?view=office-pia"/>
  public float Position { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.transparency?view=office-pia"/>
  public float Transparency { get; set; }
}

