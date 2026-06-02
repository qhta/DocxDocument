namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren?view=word-pia"/>
public partial interface IDiagramNodeChildren
{
  /// <summary>
  /// Adds a node to the diagram node's children collection.
  /// </summary>
  /// <param name="Index">The position at which to insert the node.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="DiagramNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.addnode?view=word-pia"/>
  public DiagramNode AddNode(object Index, Core.DiagramNodeType NodeType);
}
