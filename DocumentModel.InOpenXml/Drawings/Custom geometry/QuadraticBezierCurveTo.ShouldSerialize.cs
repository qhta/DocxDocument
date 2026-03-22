namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class QuadraticBezierCurveTo
{
  public bool ShouldSerializePoints() => Points is not null;
}
