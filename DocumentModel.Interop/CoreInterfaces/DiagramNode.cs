
namespace DocumentModel.Interop.Core;

public interface DiagramNode: InteropObject
{
  DiagramNode AddNode
  (MsoRelativeNodePosition Pos,
    MsoDiagramNodeType NodeType);

  void Delete();
  void MoveNode(DiagramNode TargetNode, MsoRelativeNodePosition Pos);
  void ReplaceNode(DiagramNode TargetNode);
  void SwapNode(DiagramNode TargetNode, bool SwapChildren);

  DiagramNode CloneNode
    (bool CopyChildren, DiagramNode TargetNode, MsoRelativeNodePosition Pos);

  void TransferChildren(DiagramNode ReceivingNode);
  DiagramNode NextNode();
  DiagramNode PrevNode();
  DiagramNodeChildren Children { get; }
  Shape Shape { get; }
  DiagramNode Root { get; }
  IMsoDiagram Diagram { get; }
  MsoOrgChartLayoutType Layout { get; set; }
  Shape TextShape { get; }
}