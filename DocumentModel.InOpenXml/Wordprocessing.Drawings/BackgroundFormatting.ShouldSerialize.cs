namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class BackgroundFormatting
{
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
}
