
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode?view=office-pia
/// </remarks>
public partial interface DiagramNode
{
  /// <summary>
  /// Invokes `AddNode`.
  /// </summary>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.addnode?view=office-pia
  /// </remarks>
  public DiagramNode AddNode
  (MsoRelativeNodePosition Pos,
    MsoDiagramNodeType NodeType);
  /// <summary>
  /// Deletes the diagram node.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Invokes `MoveNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.movenode?view=office-pia
  /// </remarks>
  public void MoveNode(DiagramNode TargetNode, MsoRelativeNodePosition Pos);
  /// <summary>
  /// Invokes `ReplaceNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.replacenode?view=office-pia
  /// </remarks>
  public void ReplaceNode(DiagramNode TargetNode);
  /// <summary>
  /// Invokes `SwapNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="SwapChildren">The `SwapChildren` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.swapnode?view=office-pia
  /// </remarks>
  public void SwapNode(DiagramNode TargetNode, bool SwapChildren);
  /// <summary>
  /// Invokes `CloneNode`.
  /// </summary>
  /// <param name="CopyChildren">The `CopyChildren` parameter.</param>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.clonenode?view=office-pia
  /// </remarks>
  public DiagramNode CloneNode
    (bool CopyChildren, DiagramNode TargetNode, MsoRelativeNodePosition Pos);
  /// <summary>
  /// Invokes `TransferChildren`.
  /// </summary>
  /// <param name="ReceivingNode">The `ReceivingNode` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.transferchildren?view=office-pia
  /// </remarks>
  public void TransferChildren(DiagramNode ReceivingNode);
  /// <summary>
  /// Invokes `NextNode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.nextnode?view=office-pia
  /// </remarks>
  public DiagramNode NextNode();
  /// <summary>
  /// Invokes `PrevNode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.prevnode?view=office-pia
  /// </remarks>
  public DiagramNode PrevNode();
}
