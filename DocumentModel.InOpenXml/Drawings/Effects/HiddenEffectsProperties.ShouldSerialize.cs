namespace DocumentModel.Drawings;

public partial class HiddenEffectsProperties
{
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
