
namespace DocumentModel.Interop.Core;

public partial interface SmartArtNode: InteropObject
{
  public MsoOrgChartLayoutType OrgChartLayout { get; set; }
  public ShapeRange Shapes { get; }
  public TextFrame2 TextFrame2 { get; }
  public int Level { get; }
  public MsoTriState Hidden { get; }
  public SmartArtNodes Nodes { get; }
  public SmartArtNode ParentNode { get; }
  public MsoSmartArtNodeType Type { get; }
}
