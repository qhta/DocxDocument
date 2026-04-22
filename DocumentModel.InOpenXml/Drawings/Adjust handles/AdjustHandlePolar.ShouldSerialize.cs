namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AdjustHandlePolar
{
  public bool ShouldSerializeRadialAdjustmentGuide() => !String.IsNullOrEmpty(RadialAdjustmentGuide);
  public bool ShouldSerializeMinRadial() => !String.IsNullOrEmpty(MinRadial);
  public bool ShouldSerializeMaxRadial() => !String.IsNullOrEmpty(MaxRadial);
  public bool ShouldSerializeAngleAdjustmentGuide() => !String.IsNullOrEmpty(AngleAdjustmentGuide);
  public bool ShouldSerializeMinAngle() => !String.IsNullOrEmpty(MinAngle);
  public bool ShouldSerializeMaxAngle() => !String.IsNullOrEmpty(MaxAngle);
  public bool ShouldSerializePosition() => Position is not null;
}
