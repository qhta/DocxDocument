using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren?view=office-pia
/// </remarks>
public partial interface DiagramNodeChildren: InteropDictionary<string, DiagramNode>
{
  /// <summary>
  /// Gets the `FirstChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.firstchild?view=office-pia
  /// </remarks>
  public DiagramNode FirstChild { get; }
  /// <summary>
  /// Gets the `LastChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.lastchild?view=office-pia
  /// </remarks>
  public DiagramNode LastChild { get; }
}
