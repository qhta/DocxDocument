
namespace DocumentModel.Interop.Core;

public interface DiagramNode: InteropObject
{
  public DiagramNode AddNode
  (MsoRelativeNodePosition Pos,
    MsoDiagramNodeType NodeType);

  public void Delete();
  public void MoveNode(DiagramNode TargetNode, MsoRelativeNodePosition Pos);
  public void ReplaceNode(DiagramNode TargetNode);
  public void SwapNode(DiagramNode TargetNode, bool SwapChildren);

  public DiagramNode CloneNode
    (bool CopyChildren, DiagramNode TargetNode, MsoRelativeNodePosition Pos);

  public void TransferChildren(DiagramNode ReceivingNode);
  public DiagramNode NextNode();
  public DiagramNode PrevNode();
  public DiagramNodeChildren Children { get; }
  public Shape Shape { get; }
  public DiagramNode Root { get; }
  public IMsoDiagram Diagram { get; }
  public MsoOrgChartLayoutType Layout { get; set; }
  public Shape TextShape { get; }
}
