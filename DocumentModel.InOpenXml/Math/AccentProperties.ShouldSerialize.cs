namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class AccentProperties
{
  public bool ShouldSerializeAccentChar() => !String.IsNullOrEmpty(AccentChar);
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
