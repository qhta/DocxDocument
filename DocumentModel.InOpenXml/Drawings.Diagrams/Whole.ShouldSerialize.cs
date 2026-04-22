namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class Whole
{
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
