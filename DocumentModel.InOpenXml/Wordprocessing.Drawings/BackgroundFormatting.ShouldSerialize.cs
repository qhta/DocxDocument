namespace DocumentModel.Wordprocessing.Drawings;

public partial class BackgroundFormatting
{
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
