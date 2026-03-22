namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class SubSuperscript
{
  public bool ShouldSerializeSubSuperscriptProperties() => SubSuperscriptProperties is not null;
  public bool ShouldSerializeBase() => Base is not null;
  public bool ShouldSerializeSubArgument() => SubArgument is not null;
  public bool ShouldSerializeSuperArgument() => SuperArgument is not null;
}
