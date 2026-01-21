namespace DocumentModel.Math;

public partial class AccentProperties
{
  public bool ShouldSerializeAccentChar() => AccentChar is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
