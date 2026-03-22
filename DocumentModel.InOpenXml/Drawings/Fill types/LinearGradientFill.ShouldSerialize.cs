namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class LinearGradientFill
{
  public bool ShouldSerializeAngle() => Angle is not null;
}
