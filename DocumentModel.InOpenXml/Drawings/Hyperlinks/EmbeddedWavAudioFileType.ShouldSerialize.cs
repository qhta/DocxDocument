namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class EmbeddedWavAudioFileType
{
  public bool ShouldSerializeEmbed() => !String.IsNullOrEmpty(Embed);
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeBuiltIn() => BuiltIn is not null;
}
