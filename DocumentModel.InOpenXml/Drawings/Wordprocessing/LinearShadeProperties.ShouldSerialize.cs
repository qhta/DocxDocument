namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class LinearShadeProperties
{
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializeScaled() => Scaled is not null;
}
