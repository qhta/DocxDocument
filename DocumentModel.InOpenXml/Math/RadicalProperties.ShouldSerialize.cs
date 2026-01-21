namespace DocumentModel.Math;

public partial class RadicalProperties
{
  public bool ShouldSerializeHideDegree() => HideDegree is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
