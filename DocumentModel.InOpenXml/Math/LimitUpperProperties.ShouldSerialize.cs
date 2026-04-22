namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class LimitUpperProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
