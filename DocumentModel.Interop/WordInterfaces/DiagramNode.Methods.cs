namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode?view=word-pia"/>
public partial interface IDiagramNode
{
  /// <summary>
  /// Adds a node to the diagram relative to the current node.
  /// </summary>
  /// <param name="Pos">The relative position where the new node is inserted.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="DiagramNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.addnode?view=word-pia"/>
  public DiagramNode AddNode(Core.RelativeNodePosition Pos, Core.DiagramNodeType NodeType);
}
