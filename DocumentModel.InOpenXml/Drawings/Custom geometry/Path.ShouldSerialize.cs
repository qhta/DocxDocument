namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Path
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeStroke() => Stroke is not null;
  public bool ShouldSerializeExtrusionOk() => ExtrusionOk is not null;
  public bool ShouldSerializeCloseShapePath() => CloseShapePath is not null;
  public bool ShouldSerializeMoveTo() => MoveTo is not null;
  public bool ShouldSerializeLineTo() => LineTo is not null;
  public bool ShouldSerializeArcTo() => ArcTo is not null;
  public bool ShouldSerializeQuadraticBezierCurveTo() => QuadraticBezierCurveTo is not null;
  public bool ShouldSerializeCubicBezierCurveTo() => CubicBezierCurveTo is not null;
}
