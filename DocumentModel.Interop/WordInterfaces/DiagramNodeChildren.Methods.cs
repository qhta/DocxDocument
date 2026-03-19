namespace DocumentModel.Interop.Word;

public partial interface DiagramNodeChildren
{
  /// <summary>
  /// Adds a node to the diagram node's children collection.
  /// </summary>
  /// <param name="Index">The position at which to insert the node.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="DiagramNode"/> object.</returns>
  public DiagramNode AddNode(object Index, Core.MsoDiagramNodeType NodeType);
}
