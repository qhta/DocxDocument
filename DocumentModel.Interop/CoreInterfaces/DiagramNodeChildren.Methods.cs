using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren?view=office-pia
/// </remarks>
public partial interface DiagramNodeChildren
{
  /// <summary>
  /// Returns a child diagram node by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.item?view=office-pia
  /// </remarks>
  public DiagramNode Item(object Index);
  /// <summary>
  /// Adds a child node to the diagram node children collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.addnode?view=office-pia
  /// </remarks>
  public DiagramNode AddNode(object Index, MsoDiagramNodeType NodeType);
  /// <summary>
  /// Selects all child diagram nodes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.selectall?view=office-pia
  /// </remarks>
  public void SelectAll();
}
