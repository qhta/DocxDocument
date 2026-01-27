namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Accent
{
  public bool ShouldSerializeAccentProperties() => AccentProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
