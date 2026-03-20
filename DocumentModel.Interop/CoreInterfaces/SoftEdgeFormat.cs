
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SoftEdgeFormat` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat?view=office-pia
/// </remarks>
public partial interface SoftEdgeFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat.type?view=office-pia
  /// </remarks>
  public MsoSoftEdgeType Type { get; set; }
  /// <summary>
  /// Gets or sets the `Radius` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat.radius?view=office-pia
  /// </remarks>
  public float Radius { get; set; }
}
