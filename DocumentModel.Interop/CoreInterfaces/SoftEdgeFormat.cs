
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SoftEdgeFormat` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat?view=office-pia"/>
public partial interface ISoftEdgeFormat: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat.type?view=office-pia"/>
  public SoftEdgeType Type { get; set; }
  /// <summary>
  /// Gets or sets the `Radius` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat.radius?view=office-pia"/>
  public float Radius { get; set; }
}

