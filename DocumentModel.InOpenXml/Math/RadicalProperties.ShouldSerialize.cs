namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class RadicalProperties
{
  public bool ShouldSerializeHideDegree() => HideDegree is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
