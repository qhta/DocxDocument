namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class HiddenEffectsProperties
{
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
