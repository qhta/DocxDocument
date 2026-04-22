namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Superscript
{
  public bool ShouldSerializeSuperscriptProperties() => SuperscriptProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
  public bool ShouldSerializeSuperArgument() => SuperArgument is not null;
}
