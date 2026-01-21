namespace DocumentModel.Wordprocessing.Drawings;

public partial class WholeFormatting
{
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
