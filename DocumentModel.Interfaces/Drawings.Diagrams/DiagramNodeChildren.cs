using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren?view=office-pia"/>
public partial interface DiagramNodeChildren: IModelCollection<DiagramNode>
{
  /// <summary>
  /// Gets the `FirstChild` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.firstchild?view=office-pia"/>
  public DiagramNode FirstChild { get; }
  /// <summary>
  /// Gets the `LastChild` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.lastchild?view=office-pia"/>
  public DiagramNode LastChild { get; }
}

