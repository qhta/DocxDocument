
namespace DocumentModel.Interop.Core;

public interface SmartArtNode: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }

  SmartArtNode AddNode
  (MsoSmartArtNodePosition Position = MsoSmartArtNodePosition.msoSmartArtNodeDefault,
    MsoSmartArtNodeType Type = MsoSmartArtNodeType.msoSmartArtNodeTypeDefault);

  void Delete();
  void Promote();
  void Demote();
  MsoOrgChartLayoutType OrgChartLayout { get; set; }
  ShapeRange Shapes { get; }
  TextFrame2 TextFrame2 { get; }
  void Larger();
  void Smaller();
  int Level { get; }
  MsoTriState Hidden { get; }
  SmartArtNodes Nodes { get; }
  SmartArtNode ParentNode { get; }
  MsoSmartArtNodeType Type { get; }
  void ReorderUp();
  void ReorderDown();
}