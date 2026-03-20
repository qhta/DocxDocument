
namespace DocumentModel.Interop.Core;

public partial interface DiagramNode: InteropObject
{
  public DiagramNodeChildren Children { get; }
  public Shape Shape { get; }
  public DiagramNode Root { get; }
  public IMsoDiagram Diagram { get; }
  public MsoOrgChartLayoutType Layout { get; set; }
  public Shape TextShape { get; }
}
