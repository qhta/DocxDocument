
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents one gradient stop.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop?view=office-pia
/// </remarks>
public partial interface GradientStop: InteropObject
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.color?view=office-pia
  /// </remarks>
  public ColorFormat Color { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.position?view=office-pia
  /// </remarks>
  public float Position { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
}
