
namespace DocumentModel.Interop.Core;

public interface DiagramNode: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }

  DiagramNode AddNode
  (MsoRelativeNodePosition Pos = MsoRelativeNodePosition.msoAfterNode,
    MsoDiagramNodeType NodeType = MsoDiagramNodeType.msoDiagramNode);

  void Delete();
  void MoveNode(DiagramNode TargetNode, MsoRelativeNodePosition Pos);
  void ReplaceNode(DiagramNode TargetNode);
  void SwapNode(DiagramNode TargetNode, bool SwapChildren = true);

  DiagramNode CloneNode
    (bool CopyChildren, DiagramNode TargetNode, MsoRelativeNodePosition Pos = MsoRelativeNodePosition.msoAfterNode);

  void TransferChildren(DiagramNode ReceivingNode);
  DiagramNode NextNode();
  DiagramNode PrevNode();
  object Parent { get; }
  DiagramNodeChildren Children { get; }
  Shape Shape { get; }
  DiagramNode Root { get; }
  IMsoDiagram Diagram { get; }
  MsoOrgChartLayoutType Layout { get; set; }
  Shape TextShape { get; }
}