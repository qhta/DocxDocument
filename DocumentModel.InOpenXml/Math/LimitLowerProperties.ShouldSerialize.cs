namespace DocumentModel.Math;

public partial class LimitLowerProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
