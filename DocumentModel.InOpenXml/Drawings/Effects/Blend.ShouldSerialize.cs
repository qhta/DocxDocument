namespace DocumentModel.Drawings;

public partial class Blend
{
  public bool ShouldSerializeBlendMode() => BlendMode is not null;
  public bool ShouldSerializeEffectContainer() => EffectContainer is not null;
}
