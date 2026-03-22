namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class PreSubSuper
{
  public bool ShouldSerializePreSubSuperProperties() => PreSubSuperProperties is not null;
  public bool ShouldSerializeSubArgument() => SubArgument is not null;
  public bool ShouldSerializeSuperArgument() => SuperArgument is not null;
  public bool ShouldSerializeBase() => Base is not null;
}
