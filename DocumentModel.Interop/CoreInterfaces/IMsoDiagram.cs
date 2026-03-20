
namespace DocumentModel.Interop.Core;

public partial interface IMsoDiagram: InteropObject
{
  public DiagramNodes Nodes { get; }
  public MsoDiagramType Type { get; }
  public MsoTriState AutoLayout { get; set; }
  public MsoTriState Reverse { get; set; }
  public MsoTriState AutoFormat { get; set; }
}
