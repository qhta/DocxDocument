namespace DocumentModel.Drawings;

public partial class CubicBezierCurveTo
{
  public bool ShouldSerializePoints() => Points is not null;
}
