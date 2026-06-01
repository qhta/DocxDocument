using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes?view=office-pia"/>
public partial class DiagramNodes
{
  /// <summary>
  /// Returns a diagram node by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.item?view=office-pia"/>
  public DiagramNode Item(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Selects all diagram nodes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.selectall?view=office-pia"/>
  public void SelectAll() { throw new NotImplementedException(); }
}

