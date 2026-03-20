using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes?view=office-pia
/// </remarks>
public partial interface DiagramNodes
{
  /// <summary>
  /// Returns a diagram node by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.item?view=office-pia
  /// </remarks>
  public DiagramNode Item(object Index);
  /// <summary>
  /// Selects all diagram nodes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.selectall?view=office-pia
  /// </remarks>
  public void SelectAll();
}
