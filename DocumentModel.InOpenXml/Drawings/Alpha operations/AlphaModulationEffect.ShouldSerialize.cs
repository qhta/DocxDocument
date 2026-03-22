namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class AlphaModulationEffect
{
  public bool ShouldSerializeEffectContainer() => EffectContainer is not null;
}
