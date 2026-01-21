namespace DocumentModel.Drawings;

public partial class EmbeddedWavAudioFileType
{
  public bool ShouldSerializeEmbed() => Embed is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeBuiltIn() => BuiltIn is not null;
}
