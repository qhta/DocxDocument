namespace DocumentModel.Drawings;

public partial class AlphaModulationEffect
{
  public bool ShouldSerializeEffectContainer() => EffectContainer is not null;
}
