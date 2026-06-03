using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes?view=office-pia"/>
public interface IDiagramNodes: IInteropCollection<IDiagramNode>
{


  #region methods

/// <summary>
  /// Returns a diagram node by index.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.item?view=office-pia"/>
  public IDiagramNode Item(object index);
  /// <summary>
  /// Selects all diagram nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes.selectall?view=office-pia"/>
  public void SelectAll();

  #endregion methods
}

