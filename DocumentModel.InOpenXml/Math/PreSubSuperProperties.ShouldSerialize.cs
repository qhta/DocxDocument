namespace DocumentModel.Math;

public partial class PreSubSuperProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
