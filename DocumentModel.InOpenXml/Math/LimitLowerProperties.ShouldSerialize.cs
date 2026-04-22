namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class LimitLowerProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
