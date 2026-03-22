namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class BackgroundProperties
{
  public bool ShouldSerializeMode() => Mode is not null;
  public bool ShouldSerializePure() => Pure is not null;
  public bool ShouldSerializeNormal() => Normal is not null;
  public bool ShouldSerializeTargetScreenSize() => TargetScreenSize is not null;
}
