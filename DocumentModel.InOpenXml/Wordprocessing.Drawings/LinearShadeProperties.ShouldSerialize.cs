namespace DocumentModel.Wordprocessing.Drawings;

public partial class LinearShadeProperties
{
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializeScaled() => Scaled is not null;
}
