namespace DocumentModel.Math;

public partial class Superscript
{
  public bool ShouldSerializeSuperscriptProperties() => SuperscriptProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
  public bool ShouldSerializeSuperArgument() => SuperArgument is not null;
}
