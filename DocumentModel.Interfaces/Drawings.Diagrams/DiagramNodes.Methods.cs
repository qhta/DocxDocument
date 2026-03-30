using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes?view=office-pia"/>
public partial interface IDiagramNodes
{
  /// <summary>
  /// Returns a diagram node by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.item?view=office-pia"/>
  public IDiagramNode Item(object Index);
  /// <summary>
  /// Selects all diagram nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.selectall?view=office-pia"/>
  public void SelectAll();
}

