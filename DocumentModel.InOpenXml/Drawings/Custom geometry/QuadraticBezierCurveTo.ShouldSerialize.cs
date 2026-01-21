namespace DocumentModel.Drawings;

public partial class QuadraticBezierCurveTo
{
  public bool ShouldSerializePoints() => Points is not null;
}
