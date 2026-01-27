namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class RunProperties
{
  public bool ShouldSerializeLiteral() => Literal is not null;
  public bool ShouldSerializeNormalText() => NormalText is not null;
  public bool ShouldSerializeScript() => Script is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeBreak() => Break is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
}
