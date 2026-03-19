namespace DocumentModel.Interop.Word;

public partial interface DiagramNode
{
  /// <summary>
  /// Adds a node to the diagram relative to the current node.
  /// </summary>
  /// <param name="Pos">The relative position where the new node is inserted.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="DiagramNode"/> object.</returns>
  public DiagramNode AddNode(Core.MsoRelativeNodePosition Pos, Core.MsoDiagramNodeType NodeType);
}
