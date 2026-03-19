
namespace DocumentModel.Interop.Core;

public interface IMsoChartFormat
{
  FillFormat Fill { get; }
  GlowFormat Glow { get; }
  LineFormat Line { get; }
  object Parent { get; }
  PictureFormat PictureFormat { get; }
  ShadowFormat Shadow { get; }
  SoftEdgeFormat SoftEdge { get; }
  TextFrame2 TextFrame2 { get; }
  ThreeDFormat ThreeD { get; }
  object Application { get; }
  int Creator { get; }
  Adjustments Adjustments { get; }
  MsoAutoShapeType AutoShapeType { get; set; }
}