
namespace DocumentModel.Interop.Core;

public interface SmartArtNode: InteropObject
{
  public SmartArtNode AddNode
  (MsoSmartArtNodePosition Position,
    MsoSmartArtNodeType Type);

  public void Delete();
  public void Promote();
  public void Demote();
  public MsoOrgChartLayoutType OrgChartLayout { get; set; }
  public ShapeRange Shapes { get; }
  public TextFrame2 TextFrame2 { get; }
  public void Larger();
  public void Smaller();
  public int Level { get; }
  public MsoTriState Hidden { get; }
  public SmartArtNodes Nodes { get; }
  public SmartArtNode ParentNode { get; }
  public MsoSmartArtNodeType Type { get; }
  public void ReorderUp();
  public void ReorderDown();
}
