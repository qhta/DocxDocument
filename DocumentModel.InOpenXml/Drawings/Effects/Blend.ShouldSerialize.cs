namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class Blend
{
  public bool ShouldSerializeBlendMode() => BlendMode is not null;
  public bool ShouldSerializeEffectContainer() => EffectContainer is not null;
}
