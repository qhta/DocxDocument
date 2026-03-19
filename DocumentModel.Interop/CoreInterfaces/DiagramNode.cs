
namespace DocumentModel.Interop.Core;

public interface DiagramNode: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }

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
  object Parent { get; }
  DiagramNodeChildren Children { get; }
  Shape Shape { get; }
  DiagramNode Root { get; }
  IMsoDiagram Diagram { get; }
  MsoOrgChartLayoutType Layout { get; set; }
  Shape TextShape { get; }
}