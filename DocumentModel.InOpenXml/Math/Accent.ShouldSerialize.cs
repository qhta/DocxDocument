namespace DocumentModel.Math;

public partial class Accent
{
  public bool ShouldSerializeAccentProperties() => AccentProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
