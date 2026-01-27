namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AdjustHandlePolar
{
  public bool ShouldSerializeRadialAdjustmentGuide() => RadialAdjustmentGuide is not null;
  public bool ShouldSerializeMinRadial() => MinRadial is not null;
  public bool ShouldSerializeMaxRadial() => MaxRadial is not null;
  public bool ShouldSerializeAngleAdjustmentGuide() => AngleAdjustmentGuide is not null;
  public bool ShouldSerializeMinAngle() => MinAngle is not null;
  public bool ShouldSerializeMaxAngle() => MaxAngle is not null;
  public bool ShouldSerializePosition() => Position is not null;
}
