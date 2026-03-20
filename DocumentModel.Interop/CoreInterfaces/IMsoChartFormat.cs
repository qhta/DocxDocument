
namespace DocumentModel.Interop.Core;

public partial interface IMsoChartFormat
{
  public FillFormat Fill { get; }
  public GlowFormat Glow { get; }
  public LineFormat Line { get; }
  public PictureFormat PictureFormat { get; }
  public ShadowFormat Shadow { get; }
  public SoftEdgeFormat SoftEdge { get; }
  public TextFrame2 TextFrame2 { get; }
  public ThreeDFormat ThreeD { get; }
  public Adjustments Adjustments { get; }
  public MsoAutoShapeType AutoShapeType { get; set; }
}
