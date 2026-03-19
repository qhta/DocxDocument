namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class Background
{
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null && EffectList.Count > 0;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
