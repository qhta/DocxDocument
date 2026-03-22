namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class CubicBezierCurveTo
{
  public bool ShouldSerializePoints() => Points is not null;
}
