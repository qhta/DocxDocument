
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode?view=office-pia"/>
public partial class DiagramNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `Children` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.children?view=office-pia"/>
  public DiagramNodeChildren Children { get; }
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.shape?view=office-pia"/>
  public Shape Shape { get; }
  /// <summary>
  /// Gets the `Root` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.root?view=office-pia"/>
  public DiagramNode Root { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.diagram?view=office-pia"/>
  public MsoDiagram Diagram { get; }
  /// <summary>
  /// Gets or sets the `Layout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.layout?view=office-pia"/>
  public OrgChartLayoutType Layout { get; set; }
  /// <summary>
  /// Gets the `TextShape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.textshape?view=office-pia"/>
  public Shape TextShape { get; }


  #region methods

/// <summary>
  /// Invokes `AddNode`.
  /// </summary>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.addnode?view=office-pia"/>
  public DiagramNode AddNode
  (RelativeNodePosition Pos,
    DiagramNodeType NodeType) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the diagram node.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `MoveNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.movenode?view=office-pia"/>
  public void MoveNode(DiagramNode TargetNode, RelativeNodePosition Pos) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ReplaceNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.replacenode?view=office-pia"/>
  public void ReplaceNode(DiagramNode TargetNode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SwapNode`.
  /// </summary>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="SwapChildren">The `SwapChildren` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.swapnode?view=office-pia"/>
  public void SwapNode(DiagramNode TargetNode, bool SwapChildren) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CloneNode`.
  /// </summary>
  /// <param name="CopyChildren">The `CopyChildren` parameter.</param>
  /// <param name="TargetNode">The `TargetNode` parameter.</param>
  /// <param name="Pos">The `Pos` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.clonenode?view=office-pia"/>
  public DiagramNode CloneNode
    (bool CopyChildren, DiagramNode TargetNode, RelativeNodePosition Pos) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `TransferChildren`.
  /// </summary>
  /// <param name="ReceivingNode">The `ReceivingNode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.transferchildren?view=office-pia"/>
  public void TransferChildren(DiagramNode ReceivingNode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `NextNode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.nextnode?view=office-pia"/>
  public DiagramNode NextNode() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PrevNode`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.prevnode?view=office-pia"/>
  public DiagramNode PrevNode() { throw new NotImplementedException(); }

  #endregion methods
}

