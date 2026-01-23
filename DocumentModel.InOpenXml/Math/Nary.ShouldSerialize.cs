namespace DocumentModel.Math;

public partial class Nary
{
  public bool ShouldSerializeNaryProperties() => NaryProperties is not null;
  public bool ShouldSerializeSubArgument() => SubArgument is not null;
  public bool ShouldSerializeSuperArgument() => SuperArgument is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
