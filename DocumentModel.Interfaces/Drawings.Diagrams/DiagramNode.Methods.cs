
namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode?view=office-pia"/>
public partial interface IDiagramNode
{
  /// <summary>
  /// Invokes `AddNode`.
  /// </summary>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.addnode?view=office-pia"/>
  public IDiagramNode AddNode
  (RelativeNodePosition Pos,
    DiagramNodeType NodeType);
  /// <summary>
  /// Deletes the diagram node.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Invokes `MoveNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.movenode?view=office-pia"/>
  public void MoveNode(IDiagramNode TargetNode, RelativeNodePosition Pos);
  /// <summary>
  /// Invokes `ReplaceNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.replacenode?view=office-pia"/>
  public void ReplaceNode(IDiagramNode TargetNode);
  /// <summary>
  /// Invokes `SwapNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="SwapChildren">The `SwapChildren` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.swapnode?view=office-pia"/>
  public void SwapNode(IDiagramNode TargetNode, bool SwapChildren);
  /// <summary>
  /// Invokes `CloneNode`.
  /// </summary>
  /// <param name="CopyChildren">The `CopyChildren` parameter.</param>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.clonenode?view=office-pia"/>
  public IDiagramNode CloneNode
    (bool CopyChildren, IDiagramNode TargetNode, RelativeNodePosition Pos);
  /// <summary>
  /// Invokes `TransferChildren`.
  /// </summary>
  /// <param name="ReceivingNode">The `ReceivingNode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.transferchildren?view=office-pia"/>
  public void TransferChildren(IDiagramNode ReceivingNode);
  /// <summary>
  /// Invokes `NextNode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.nextnode?view=office-pia"/>
  public IDiagramNode NextNode();
  /// <summary>
  /// Invokes `PrevNode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.prevnode?view=office-pia"/>
  public IDiagramNode PrevNode();
}

