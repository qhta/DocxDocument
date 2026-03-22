namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class AccentProperties
{
  public bool ShouldSerializeAccentChar() => AccentChar is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
