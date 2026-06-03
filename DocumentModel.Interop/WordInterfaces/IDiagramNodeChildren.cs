namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of DiagramNode objects that represents the child nodes in a diagram.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren?view=word-pia"/>
public interface IDiagramNodeChildren : IInteropObject, IInteropCollection<IDiagramNode>
{
  /// <summary>
  /// Gets the first child node in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.firstchild?view=word-pia"/>
  public IDiagramNode FirstChild { get; }

  /// <summary>
  /// Gets the last child node in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.lastchild?view=word-pia"/>
  public IDiagramNode LastChild { get; }


  #region methods

/// <summary>
  /// Adds a node to the diagram node's children collection.
  /// </summary>
  /// <param name="Index">The position at which to insert the node.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="IDiagramNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.addnode?view=word-pia"/>
  public IDiagramNode AddNode(object Index, Core.DiagramNodeType NodeType);

  #endregion methods
}
