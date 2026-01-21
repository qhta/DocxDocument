namespace DocumentModel.Drawings;

public partial class LinearGradientFill
{
  public bool ShouldSerializeAngle() => Angle is not null;
}
