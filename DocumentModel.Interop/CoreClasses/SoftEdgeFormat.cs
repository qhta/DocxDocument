
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SoftEdgeFormat` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat?view=office-pia"/>
public partial class SoftEdgeFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat.type?view=office-pia"/>
  public SoftEdgeType Type { get; set; }
  /// <summary>
  /// Gets or sets the `Radius` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.softedgeformat.radius?view=office-pia"/>
  public float Radius { get; set; }
}

