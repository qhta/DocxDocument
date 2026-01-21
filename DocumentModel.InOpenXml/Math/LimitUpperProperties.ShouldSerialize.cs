namespace DocumentModel.Math;

public partial class LimitUpperProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
