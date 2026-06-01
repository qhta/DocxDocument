using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren?view=office-pia"/>
public partial class DiagramNodeChildren
{
  /// <summary>
  /// Returns a child diagram node by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.item?view=office-pia"/>
  public DiagramNode Item(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Adds a child node to the diagram node children collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.addnode?view=office-pia"/>
  public DiagramNode AddNode(object Index, DiagramNodeType NodeType) { throw new NotImplementedException(); }
  /// <summary>
  /// Selects all child diagram nodes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodechildren.selectall?view=office-pia"/>
  public void SelectAll() { throw new NotImplementedException(); }
}

