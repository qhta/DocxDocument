namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Nary
{
  public bool ShouldSerializeNaryProperties() => NaryProperties is not null;
  public bool ShouldSerializeSubArgument() => SubArgument is not null;
  public bool ShouldSerializeSuperArgument() => SuperArgument is not null;
  public bool ShouldSerializeArgument() => Base is not null;
}
